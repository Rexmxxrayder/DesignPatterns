using System;

namespace DesignPatterns.Structural.FlyweightPattern;

public class CropService
{
    private CropIconFactory _iconFactory;

    public CropService(CropIconFactory iconFactory){
        _iconFactory = iconFactory;
    }
    public List<Crop> GetCrops()
    {
        List<Crop> crops = new List<Crop>();

        var carrot = new Crop(1, 4, _iconFactory.GetCropIcon(CropType.CARROT));
        var potato = new Crop(1, 3, _iconFactory.GetCropIcon(CropType.POTATO));
        var wheat = new Crop(5, 4, _iconFactory.GetCropIcon(CropType.WHEAT));

        crops.Add(carrot);
        crops.Add(potato);
        crops.Add(wheat);

        return crops;
    }
}