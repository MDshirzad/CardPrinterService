﻿using CSharpFunctionalExtensions;
using SharedKernel;
using System.Drawing;

namespace Utility.Contracts
{
    public interface IImageUtility
    {
        public string GetVarnishImageBase64();
        public Result StoreFrontKImage(string base64, Enums.RibbonType type);
        Result<string> StoreLaserImage(string base64CardData, bool isBack, RotateFlipType rotateFlipType = RotateFlipType.Rotate180FlipNone);
        Result<(string KFilePath, string ColoredFilePath)> StoreColored(string base64CardData, string base64CardImage);
        Result<(string BackKFilePath, string BackColoredPath)> StoreBackColored(string base64CardData, string base64CardImage);
    }
}
