using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldStreamingWorld : CResource
	{
		[Ordinal(0)]  [RED("version")] public CUInt32 Version { get; set; }
		[Ordinal(1)]  [RED("exteriorSectors")] public CArray<worldStreamingSectorDescriptor> ExteriorSectors { get; set; }
		[Ordinal(2)]  [RED("interiorSectors")] public CArray<worldStreamingSectorDescriptor> InteriorSectors { get; set; }
		[Ordinal(3)]  [RED("questSectors")] public CArray<worldStreamingSectorDescriptor> QuestSectors { get; set; }
		[Ordinal(4)]  [RED("alwaysLoadedSectors")] public CArray<worldStreamingSectorDescriptor> AlwaysLoadedSectors { get; set; }
		[Ordinal(5)]  [RED("environmentDefinition")] public rRef<worldEnvironmentDefinition> EnvironmentDefinition { get; set; }
		[Ordinal(6)]  [RED("worldBoundingBox")] public Box WorldBoundingBox { get; set; }
		[Ordinal(7)]  [RED("persistentStateData")] public rRef<CResource> PersistentStateData { get; set; }
		[Ordinal(8)]  [RED("deviceResource")] public rRef<CResource> DeviceResource { get; set; }
		[Ordinal(9)]  [RED("deviceInitResource")] public rRef<CResource> DeviceInitResource { get; set; }
		[Ordinal(10)]  [RED("mappinResource")] public rRef<CResource> MappinResource { get; set; }
		[Ordinal(11)]  [RED("poiMappinResource")] public rRef<CResource> PoiMappinResource { get; set; }
		[Ordinal(12)]  [RED("areaResource")] public rRef<CResource> AreaResource { get; set; }
		[Ordinal(13)]  [RED("lootResource")] public rRef<CResource> LootResource { get; set; }
		[Ordinal(14)]  [RED("locationResource")] public rRef<CResource> LocationResource { get; set; }
		[Ordinal(15)]  [RED("locomotionPathResource")] public raRef<CResource> LocomotionPathResource { get; set; }
		[Ordinal(16)]  [RED("autoFoliageMapping")] public raRef<worldAutoFoliageMapping> AutoFoliageMapping { get; set; }
		[Ordinal(17)]  [RED("trafficPersistentResource")] public raRef<CResource> TrafficPersistentResource { get; set; }
		[Ordinal(18)]  [RED("trafficLaneConnectivityResource")] public raRef<CResource> TrafficLaneConnectivityResource { get; set; }
		[Ordinal(19)]  [RED("trafficLanePolygonsResource")] public raRef<CResource> TrafficLanePolygonsResource { get; set; }
		[Ordinal(20)]  [RED("trafficLaneSpotsResource")] public raRef<CResource> TrafficLaneSpotsResource { get; set; }
		[Ordinal(21)]  [RED("trafficSpatialRepresentationResource")] public raRef<CResource> TrafficSpatialRepresentationResource { get; set; }
		[Ordinal(22)]  [RED("trafficCollisionResource")] public raRef<CResource> TrafficCollisionResource { get; set; }
		[Ordinal(23)]  [RED("trafficNullAreaCollisionResource")] public raRef<CResource> TrafficNullAreaCollisionResource { get; set; }
		[Ordinal(24)]  [RED("smartObjectCompiledRootResource")] public raRef<CResource> SmartObjectCompiledRootResource { get; set; }
		[Ordinal(25)]  [RED("geometryCacheResource")] public rRef<CResource> GeometryCacheResource { get; set; }
		[Ordinal(26)]  [RED("wasBuiltForSceneRecording")] public CBool WasBuiltForSceneRecording { get; set; }
		[Ordinal(27)]  [RED("streamingQueryDataResource")] public raRef<worldStreamingQueryDataResource> StreamingQueryDataResource { get; set; }

		public worldStreamingWorld(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
