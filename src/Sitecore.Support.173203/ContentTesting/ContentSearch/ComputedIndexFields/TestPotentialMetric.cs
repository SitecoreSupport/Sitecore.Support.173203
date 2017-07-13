namespace Sitecore.Support.ContentTesting.ContentSearch.ComputedIndexFields
{
    using Sitecore.ContentSearch;
    public class TestPotentialMetric : Sitecore.ContentTesting.ContentSearch.ComputedIndexFields.TestPotentialMetric
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