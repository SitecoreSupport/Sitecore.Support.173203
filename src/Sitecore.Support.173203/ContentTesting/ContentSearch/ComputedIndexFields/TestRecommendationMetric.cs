namespace Sitecore.Support.ContentTesting.ContentSearch.ComputedIndexFields
{
    using Sitecore.ContentSearch;
    public class TestRecommendationMetric : Sitecore.ContentTesting.ContentSearch.ComputedIndexFields.TestRecommendationMetric
    {
        public override object ComputeFieldValue(IIndexable indexable)
        {
            if (Xdb.Configuration.XdbSettings.Enabled)
            {
                return base.ComputeFieldValue(indexable);
            }
            return null;
        }
    }
}