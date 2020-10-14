using NGeoNames;
using NGeoNames.Entities;
using System.Collections.Generic;


namespace geocode.Extensions
{
	static class ReverseGeoCodingExtensions
	{
		public static IEnumerable<ExtendedGeoName> RadialSearch(this ReverseGeoCode<ExtendedGeoName> reverseGeoCode, (double Lat, double Lng) position, int maxCount)
		{
			return reverseGeoCode.RadialSearch(position.Lat, position.Lng, maxCount);
		}
	}
}
