namespace AlgoExpert.Easy;

internal class ClassPhotos
{
    public bool IsPhotoPossible(List<int> redShirtHeights, List<int> blueShirtHeights)
    {
        redShirtHeights.Sort((a,b) => b - a);
        blueShirtHeights.Sort((a,b) => b - a);

        bool isRedTaller = redShirtHeights[0] > blueShirtHeights[0];

        for (int i = 2; i < redShirtHeights.Count; i++)
        {
            if (isRedTaller)
            {
                if (redShirtHeights[i] <= blueShirtHeights[i]) return false;
            }
            else
            {
                if (redShirtHeights[i] >= blueShirtHeights[i]) return false;
            }
        }
        return isRedTaller;
    }
}
