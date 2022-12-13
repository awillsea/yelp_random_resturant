using Yelp.Api.Models;

namespace Random_Restruant.Models
{
    public class Yelp_DAL
    {

        public static HttpClient _web = null;


        public static HttpClient GetHttpClient()
        {
            var accesstoken = "PIUZTblrnJ0TCwXLfSbXOzhHHC2_3td - i0hfiCKFsV8JMrd6WRjfWHvbAdPV_DJCi - 6bxK2_h4bGu7M06WGikMVr8e_q_HMKUaD6Xf - cLazQLsztWeQeCM4uz3NNY3Yx";


            if (_web == null)
            {
                _web = new HttpClient();
                _web.BaseAddress = new Uri("https://api.yelp.com/v3/"); 
                
                _web.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue($"Bearer",$"{accesstoken}");
            }
            return _web;
        }
        async public static Task<YelpCs> Test()
        {
           
            var client = new Yelp.Api.Client("PIUZTblrnJ0TCwXLfSbXOzhHHC2_3td - i0hfiCKFsV8JMrd6WRjfWHvbAdPV_DJCi - 6bxK2_h4bGu7M06WGikMVr8e_q_HMKUaD6Xf - cLazQLsztWeQeCM4uz3NNY3Yx");
            var result = await client.SearchBusinessesAllAsync("mexican", 33.3062, -111.8413);
            YelpCs newz = new YelpCs();
            return newz;
            
        }
        async public static Task<YelpCs> Resturants() {
           // string accesstoken = "PIUZTblrnJ0TCwXLfSbXOzhHHC2_3td-i0hfiCKFsV8JMrd6WRjfWHvbAdPV_DJCi-6bxK2_h4bGu7M06WGikMVr8e_q_HMKUaD6Xf-cLazQLsztWeQeCM4uz3NNY3Yx";

            HttpClient web = GetHttpClient();
            var connection = await web.GetAsync("businesses/search?location=az");
          //  connection.Headers.Add("Bearer", accesstoken);
        
            YelpCs azyelp = await connection.Content.ReadAsAsync<YelpCs>();
            return azyelp;
        }
    }
}
