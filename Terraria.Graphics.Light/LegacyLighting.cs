using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.Graphics.Light;

[Cpp2IlInjected.Token(Token = "0x2000510")]
public class LegacyLighting : ILightingEngine
{
	[Cpp2IlInjected.Token(Token = "0x2000969")]
	private class ColorTriplet
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008BBD")]
		public float R;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008BBE")]
		public float G;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4008BBF")]
		public float B;

		[Cpp2IlInjected.Token(Token = "0x6004DAC")]
		[Cpp2IlInjected.Address(RVA = "0x1510E38", Offset = "0x1510E38", VA = "0x1510E38")]
		public ColorTriplet(float R, float G, float B)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004DAD")]
		[Cpp2IlInjected.Address(RVA = "0x150E57C", Offset = "0x150E57C", VA = "0x150E57C")]
		public ColorTriplet(float averageColor)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4006813")]
	public static int RenderPhases;

	[Cpp2IlInjected.Token(Token = "0x4006814")]
	private static short tempLightOffset;

	[Cpp2IlInjected.Token(Token = "0x4006815")]
	private static List<ColorTriplet> tempLightData;

	[Cpp2IlInjected.Token(Token = "0x4006816")]
	private static Dictionary<int, short> tempLights;

	[Cpp2IlInjected.Token(Token = "0x4006817")]
	private const int AREA_PADDING = 20;

	[Cpp2IlInjected.Token(Token = "0x4006818")]
	private const int NON_VISIBLE_PADDING = 0;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006819")]
	private float _oldSkyColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400681A")]
	private float _skyColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400681B")]
	private LightMap _activeLightMap;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400681C")]
	private Rectangle _activeProcessedArea;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400681D")]
	private LightMap _workingLightMap;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400681E")]
	private Rectangle _workingProcessedArea;

	[Cpp2IlInjected.Token(Token = "0x400681F")]
	private const int MAX_TEMP_LIGHTS = 2000;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4006820")]
	private TileLightScanner _tileScanner;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4006821")]
	private readonly Camera _camera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4006823")]
	private Rectangle screenRegionScan;

	[Cpp2IlInjected.Token(Token = "0x170006FD")]
	public int Mode
	{
		[Cpp2IlInjected.Token(Token = "0x6003816")]
		[Cpp2IlInjected.Address(RVA = "0x150DB14", Offset = "0x150DB14", VA = "0x150DB14")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6003817")]
		[Cpp2IlInjected.Address(RVA = "0x150DB1C", Offset = "0x150DB1C", VA = "0x150DB1C")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170006FE")]
	public bool IsColorOrWhiteMode
	{
		[Cpp2IlInjected.Token(Token = "0x6003818")]
		[Cpp2IlInjected.Address(RVA = "0x150DB24", Offset = "0x150DB24", VA = "0x150DB24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003819")]
	[Cpp2IlInjected.Address(RVA = "0x150DB38", Offset = "0x150DB38", VA = "0x150DB38")]
	public LegacyLighting(Camera camera)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600381A")]
	[Cpp2IlInjected.Address(RVA = "0x150DEFC", Offset = "0x150DEFC", VA = "0x150DEFC", Slot = "9")]
	public LightMap GetLightMap(out Rectangle lightMapRegion)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600381B")]
	[Cpp2IlInjected.Address(RVA = "0x150DF10", Offset = "0x150DF10", VA = "0x150DF10", Slot = "7")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x39492C", Offset = "0x39492C")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x39492C", Offset = "0x39492C")]
	public Vector3 GetColor(int x, int y)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600381C")]
	[Cpp2IlInjected.Address(RVA = "0x150E070", Offset = "0x150E070", VA = "0x150E070", Slot = "4")]
	public void Rebuild()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600381D")]
	[Cpp2IlInjected.Address(RVA = "0x150E240", Offset = "0x150E240", VA = "0x150E240", Slot = "5")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x3949E0", Offset = "0x3949E0")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x3949E0", Offset = "0x3949E0")]
	public void AddLight(int x, int y, Vector3 color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600381E")]
	[Cpp2IlInjected.Address(RVA = "0x150E5A4", Offset = "0x150E5A4", VA = "0x150E5A4", Slot = "6")]
	public void ProcessArea(Rectangle area)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600381F")]
	[Cpp2IlInjected.Address(RVA = "0x15104BC", Offset = "0x15104BC", VA = "0x15104BC", Slot = "10")]
	public Rectangle GetScanRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x6003820")]
	[Cpp2IlInjected.Address(RVA = "0x150EBA0", Offset = "0x150EBA0", VA = "0x150EBA0")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x394A94", Offset = "0x394A94")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x394A94", Offset = "0x394A94")]
	private void ExportToMiniMap()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003821")]
	[Cpp2IlInjected.Address(RVA = "0x150F9C8", Offset = "0x150F9C8", VA = "0x150F9C8")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x394B48", Offset = "0x394B48")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x394B48", Offset = "0x394B48")]
	private void UpdateLightToSkyColor(float tileR, float tileG, float tileB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003822")]
	[Cpp2IlInjected.Address(RVA = "0x150EAEC", Offset = "0x150EAEC", VA = "0x150EAEC")]
	private void Present()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003823")]
	[Cpp2IlInjected.Address(RVA = "0x15104CC", Offset = "0x15104CC", VA = "0x15104CC", Slot = "8")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x394BFC", Offset = "0x394BFC")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x394BFC", Offset = "0x394BFC")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003824")]
	[Cpp2IlInjected.Address(RVA = "0x150FE68", Offset = "0x150FE68", VA = "0x150FE68")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x394CB0", Offset = "0x394CB0")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x394CB0", Offset = "0x394CB0")]
	private void PreRenderPhase(Rectangle area)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003825")]
	[Cpp2IlInjected.Address(RVA = "0x151063C", Offset = "0x151063C", VA = "0x151063C")]
	private void UpdateLightDecay()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003826")]
	[Cpp2IlInjected.Address(RVA = "0x150EA2C", Offset = "0x150EA2C", VA = "0x150EA2C")]
	private void DoColors()
	{
	}
}
