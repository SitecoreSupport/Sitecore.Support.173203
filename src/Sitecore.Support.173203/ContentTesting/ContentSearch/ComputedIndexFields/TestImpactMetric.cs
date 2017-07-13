namespace Sitecore.Support.ContentTesting.ContentSearch.ComputedIndexFields
{
    using Sitecore.ContentSearch;
    public class TestImpactMetric : Sitecore.ContentTesting.ContentSearch.ComputedIndexFields.TestImpactMetric
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