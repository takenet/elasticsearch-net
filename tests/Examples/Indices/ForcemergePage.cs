using Elastic.Xunit.XunitPlumbing;
using Nest;

namespace Examples.Indices
{
	public class ForcemergePage : ExampleBase
	{
		[U(Skip = "Example not implemented")]
		public void Line10()
		{
			// tag::ca16c1f060ca653ea8fbca445359f78f[]
			var response0 = new SearchResponse<object>();
			// end::ca16c1f060ca653ea8fbca445359f78f[]

			response0.MatchesExample(@"POST /twitter/_forcemerge");
		}

		[U(Skip = "Example not implemented")]
		public void Line139()
		{
			// tag::6733f91e27b6d5907d7c58546bc45ca1[]
			var response0 = new SearchResponse<object>();
			// end::6733f91e27b6d5907d7c58546bc45ca1[]

			response0.MatchesExample(@"POST /kimchy,elasticsearch/_forcemerge");
		}

		[U(Skip = "Example not implemented")]
		public void Line149()
		{
			// tag::480e531db799c4c909afd8e2a73a8d0b[]
			var response0 = new SearchResponse<object>();
			// end::480e531db799c4c909afd8e2a73a8d0b[]

			response0.MatchesExample(@"POST /_forcemerge");
		}

		[U(Skip = "Example not implemented")]
		public void Line165()
		{
			// tag::64d97cda667be166f3df49e87e713560[]
			var response0 = new SearchResponse<object>();
			// end::64d97cda667be166f3df49e87e713560[]

			response0.MatchesExample(@"POST /logs-000001/_forcemerge?max_num_segments=1");
		}
	}
}