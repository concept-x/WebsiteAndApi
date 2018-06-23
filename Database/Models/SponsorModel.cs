using System.Data.SqlClient;
using System.Reflection;
using DevSpace.Common;

namespace DevSpace.Database.Models {
	internal class SponsorModel : ISponsor {
		internal SponsorModel( SqlDataReader dataReader ) {
			for( int lcv = 0; lcv < dataReader.FieldCount; ++lcv ) {
				if( "LEVEL".Equals( dataReader.GetName( lcv ).ToUpper() ) ) {
					Level = ( new SponsorLevelDataStore() ).Get( dataReader.GetInt32( lcv ) ).Result;
				} else {
					GetType().GetProperty( dataReader.GetName( lcv ), BindingFlags.Instance | BindingFlags.Public )?.SetValue( this, dataReader.GetValue( lcv ) );
				}
			}
		}

		public string DisplayName { get; internal set; }
		public int Id { get; internal set; }
		public ISponsorLevel Level { get; internal set; }
		public string LogoLarge { get; internal set; }
		public string LogoSmall { get; internal set; }
		public string Website { get; internal set; }
		public int EventId { get; internal set; }
	}
}
