using System;

namespace DesignPatterns.Structural.FlyweightPattern;

public class CropIconFactory
{
    private Dictionary<CropType, CropIcon> _cropIcons = new();

    public CropIcon GetCropIcon(CropType cropType)
    {
        if (!_cropIcons.ContainsKey(cropType))
        {
            var icon = new CropIcon(cropType, null);
            _cropIcons.Add(cropType, icon);
        }

        return _cropIcons[cropType];
    }
}
