using MediatR;
using MessageHandler.Contracts;
using MessageHandler.RequestHandlers.EvolisBased.Laser.SimpleLaser;
using MessageHandler.RequestHandlers.EvolisBased.Laser.WithRoller.DoubleSideLaser.WithoutRibbon;
using MessageHandler.RequestHandlers.EvolisBased.Laser.WithRoller.DoubleSideLaser.WithRibbon.YMCKO.SingleSide;
using MessageHandler.RequestHandlers.EvolisBased.Laser.WithRoller.SingleSideLaser.Back.WithoutRibbon;
using MessageHandler.RequestHandlers.EvolisBased.Laser.WithRoller.SingleSideLaser.Front.WithoutRibbon;
using MessageHandler.RequestHandlers.EvolisBased.Laser.WithRoller.SingleSideLaser.Front.WithRibbon.YMCKO.DoubleSide;
using MessageHandler.RequestHandlers.EvolisBased.Laser.WithRoller.SingleSideLaser.Front.WithRibbon.YMCKO.SingleSide;
using MessageHandler.RequestHandlers.Info.Printer.ConnectedPrinters;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SharedKernel.Exceptions.MessageHandlers;
using System.Reflection;
using static MessageHandler.Messages.Api.RequestCodes;
namespace MessageHandler
{
    internal class CodeBaseMessageParser : IParser
    {
        public object Parse(string input)
        {

            var code = input.Substring(0, 3);
            input = input.Remove(0, 3);
            var classType = GetTypeByCommand(code);
            if (IsNonJsonType(code))
            {
               return Activator.CreateInstance(classType!)!;
            }
            if (classType == null)
                throw new JsonParserException("Invalid Code");
            try
            {
                var jsonObject = JsonConvert.DeserializeObject<JObject>(input);

                if (jsonObject == null)
                    throw new ArgumentNullException();

                var resultMap = jsonObject.ToObject(classType);
                if (resultMap == null)
                    throw new ArgumentNullException();
                return resultMap;
            }
            catch (ArgumentNullException)

            {
                throw new JsonParserException();
            }
            catch
            {

                throw new UnHandledException();
            }
        }


        Type? GetTypeByCommand(string code)
        {
            return code switch
            {
                LaserPrint_Code => typeof(LaserPrintCommand),
                LaserPrintWithRoller_Code => typeof(LaserPrintWithRollerCommand),
                LaserPrintDoubleSideWithoutRibbonWithRoller => typeof(LaserPrintDoubleSideWithoutRibbon),
                LaserPrintWithRollerWithSingleSideYmckoRibbon_Code => typeof(LaserPrintWithSingleSideYMCKO),
                LaserPrintWithRollerWithDoubleSideYmckoRibbon_Code => typeof(LaserPrintWithDoubleSideYmckoCommand),
                DoubleLaserPrintWithRollerWithSingleSideYmckoRibbon_Code => typeof(DoubleLaserSingleSideYMCKOCommand),
                DoubleLaserPrintWithRollerWithDoubleSideYmckoRibbon_Code => typeof(DoubleLaserSingleSideYMCKOCommand),
                BackSideLaserWithRoller_Code => typeof(BackSideLaserCommand),
                Printers_Info_Code => typeof(ConnectedPrintersCommand),
                _ => throw new Exception("Invalid Command")
            };

            //var type = Assembly.GetExecutingAssembly()
            //    .GetTypes()
            //    .FirstOrDefault(t => t.Name.Equals(className, StringComparison.OrdinalIgnoreCase) && typeof(IRequest).IsAssignableFrom(t));
            //return type;

        }

        bool IsNonJsonType(string code)
        {
            List<string> repo = ["100"];
            if (repo.Contains(code))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
