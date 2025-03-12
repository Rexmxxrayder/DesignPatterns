using System;

namespace DesignPatterns.Structural.FlyweightPattern;

public class CropIcon
{
    private CropType _type;
    private readonly byte[] _icon;
    public CropType Type => _type;

    public CropIcon(CropType type, byte[] icon){
        _type = type;
        _icon = icon;
    }
}
