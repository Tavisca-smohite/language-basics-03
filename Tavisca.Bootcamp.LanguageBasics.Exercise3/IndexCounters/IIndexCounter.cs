namespace Tavisca.Bootcamp.LanguageBasics.Exercise3
{
    /// <summary>
    /// Get nutrition based on given diet parameter
    /// </summary>
    public interface INutritionSelector
    {
        Nutrition[] GetNutritions(Nutrition[] nutritions ,string dietFactor);
    }
}
