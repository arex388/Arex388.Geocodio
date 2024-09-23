namespace Arex388.Geocodio;

internal static class FieldTypeExtensions {
	public static string ToValues(
		this IList<FieldType> fieldTypes) => fieldTypes.Select(
		ft => ft switch {
			FieldType.CaCensus => "statcan",
			FieldType.CaProvincialRiding => "provriding",
			FieldType.CaFederalRiding => "riding",
			FieldType.CaFederalRidingNext => "riding-next",
			FieldType.Timezone => "timezone",
			FieldType.UsAcsDemographics => "acs-demographics",
			FieldType.UsAcsEconomics => "acs-economics",
			FieldType.UsAcsFamilies => "acs-families",
			FieldType.UsAcsHousing => "acs-housing",
			FieldType.UsAcsSocial => "acs-social",
			FieldType.UsCensus => "census",
			FieldType.UsCensus2000 => "census2000",
			FieldType.UsCensus2010 => "census2010",
			FieldType.UsCensus2011 => "census2011",
			FieldType.UsCensus2012 => "census2012",
			FieldType.UsCensus2013 => "census2013",
			FieldType.UsCensus2014 => "census2014",
			FieldType.UsCensus2015 => "census2015",
			FieldType.UsCensus2016 => "census2016",
			FieldType.UsCensus2017 => "census2017",
			FieldType.UsCensus2018 => "census2018",
			FieldType.UsCensus2019 => "census2019",
			FieldType.UsCensus2020 => "census2020",
			FieldType.UsCensus2021 => "census2021",
			FieldType.UsCensus2022 => "census2022",
			FieldType.UsCensus2023 => "census2023",
			FieldType.UsCongressionalDistrict => "cd",
			FieldType.UsCongressionalDistrict113 => "cd113",
			FieldType.UsCongressionalDistrict114 => "cd114",
			FieldType.UsCongressionalDistrict115 => "cd115",
			FieldType.UsCongressionalDistrict116 => "cd116",
			FieldType.UsCongressionalDistrict117 => "cd117",
			FieldType.UsCongressionalDistrict118 => "cd118",
			FieldType.UsSchoolDistricts => "school",
			FieldType.UsStateLegislature => "stateleg",
			FieldType.UsStateLegislatureNext => "stateleg-next",
			FieldType.UsUspsZip4 => "zip4",
			_ => string.Empty
		}).StringJoin(",");
}