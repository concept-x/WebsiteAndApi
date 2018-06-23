using System.Runtime.Serialization;

namespace DevSpace.Common {
	[DataContract]
	[KnownType( typeof( SponsorLevel ) )]
	public class Sponsor : ISponsor {
		private Sponsor() {}

		[DataMember]public int Id { get; private set; }

		[DataMember( Name = "Level" )]private SponsorLevel _level;
		public ISponsorLevel Level { get { return _level; } }

		[DataMember]public string DisplayName { get; private set; }
		[DataMember]public string LogoLarge { get; private set; }
		[DataMember]public string LogoSmall { get; private set; }
		[DataMember]public string Website { get; private set; }
		[DataMember]public int EventId { get; private set; }
	}
}
