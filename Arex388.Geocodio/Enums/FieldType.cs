namespace Arex388.Geocodio;

/// <summary>
/// Field types to append to the result.
/// </summary>
public enum FieldType {
	/// <summary>
	/// Canadian statistical boundaries from Statistics Canada.
	/// </summary>
	CaCensus,

	/// <summary>
	/// Canadian Federal Electoral District.
	/// </summary>
	CaFederalRiding,

	/// <summary>
	/// Canadian Federal Electoral District.
	/// </summary>
	CaFederalRidingNext,

	/// <summary>
	/// Canadian Provincial/Territorial Electoral District.
	/// </summary>
	CaProvincialRiding,

	/// <summary>
	/// Timezone.
	/// </summary>
	Timezone,

	/// <summary>
	/// Demographics (Census).
	/// </summary>
	UsAcsDemographics,

	/// <summary>
	/// Economics: Income Data (Census).
	/// </summary>
	UsAcsEconomics,

	/// <summary>
	/// Families (Census).
	/// </summary>
	UsAcsFamilies,

	/// <summary>
	/// Housing (Census).
	/// </summary>
	UsAcsHousing,

	/// <summary>
	/// Social: Education and Veteran Status (Census).
	/// </summary>
	UsAcsSocial,

	/// <summary>
	/// Census Block/Tract, FIPS codes and MSA/CSA codes.
	/// </summary>
	UsCensus,

	/// <summary>
	/// Census Block/Tract, FIPS codes and MSA/CSA codes.
	/// </summary>
	UsCensus2000,

	/// <summary>
	/// Census Block/Tract, FIPS codes and MSA/CSA codes.
	/// </summary>
	UsCensus2010,

	/// <summary>
	/// Census Block/Tract, FIPS codes and MSA/CSA codes.
	/// </summary>
	UsCensus2011,

	/// <summary>
	/// Census Block/Tract, FIPS codes and MSA/CSA codes.
	/// </summary>
	UsCensus2012,

	/// <summary>
	/// Census Block/Tract, FIPS codes and MSA/CSA codes.
	/// </summary>
	UsCensus2013,

	/// <summary>
	/// Census Block/Tract, FIPS codes v MSA/CSA codes.
	/// </summary>
	UsCensus2014,

	/// <summary>
	/// Census Block/Tract, FIPS codes and MSA/CSA codes.
	/// </summary>
	UsCensus2015,

	/// <summary>
	/// Census Block/Tract, FIPS codes and MSA/CSA codes.
	/// </summary>
	UsCensus2016,

	/// <summary>
	/// Census Block/Tract, FIPS codes and MSA/CSA codes.
	/// </summary>
	UsCensus2017,

	/// <summary>
	/// Census Block/Tract, FIPS codes and MSA/CSA codes.
	/// </summary>
	UsCensus2018,

	/// <summary>
	/// Census Block/Tract, FIPS codes and MSA/CSA codes.
	/// </summary>
	UsCensus2019,

	/// <summary>
	/// Census Block/Tract, FIPS codes and MSA/CSA codes.
	/// </summary>
	UsCensus2020,

	/// <summary>
	/// Census Block/Tract, FIPS codes and MSA/CSA codes.
	/// </summary>
	UsCensus2021,

	/// <summary>
	/// Census Block/Tract, FIPS codes and MSA/CSA codes.
	/// </summary>
	UsCensus2022,

	/// <summary>
	/// Census Block/Tract, FIPS codes and MSA/CSA codes.
	/// </summary>
	UsCensus2023,

	/// <summary>
	/// Congressional District and Legislator information.
	/// </summary>
	UsCongressionalDistrict,

	/// <summary>
	/// Congressional District and Legislator information.
	/// </summary>
	UsCongressionalDistrict113,

	/// <summary>
	/// Congressional District and Legislator information.
	/// </summary>
	UsCongressionalDistrict114,

	/// <summary>
	/// Congressional District and Legislator information.
	/// </summary>
	UsCongressionalDistrict115,

	/// <summary>
	/// Congressional District and Legislator information.
	/// </summary>
	UsCongressionalDistrict116,

	/// <summary>
	/// Congressional District and Legislator information.
	/// </summary>
	UsCongressionalDistrict117,

	/// <summary>
	/// Congressional District and Legislator information.
	/// </summary>
	UsCongressionalDistrict118,

	/// <summary>
	/// School District (elementary/secondary or unified).
	/// </summary>
	UsSchoolDistricts,

	/// <summary>
	/// State Legislative District (House and Senate).
	/// </summary>
	UsStateLegislature,

	/// <summary>
	/// State Legislative District (House and Senate).
	/// </summary>
	UsStateLegislatureNext,

	/// <summary>
	/// USPS Zip+4 code and delivery information.
	/// </summary>
	UsUspsZip4
}