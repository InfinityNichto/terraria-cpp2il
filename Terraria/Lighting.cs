using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Graphics;
using Terraria.Graphics.Light;

namespace Terraria;

[Cpp2IlInjected.Token(Token = "0x2000318")]
public class Lighting
{
	[Cpp2IlInjected.Token(Token = "0x4002260")]
	private const float DEFAULT_GLOBAL_BRIGHTNESS = 1.2f;

	[Cpp2IlInjected.Token(Token = "0x4002261")]
	private const float BLIND_GLOBAL_BRIGHTNESS = 1f;

	[Cpp2IlInjected.Token(Token = "0x4002263")]
	[Obsolete]
	public static int OffScreenTiles;

	[Cpp2IlInjected.Token(Token = "0x17000362")]
	private static LightMode _mode
	{
		[Cpp2IlInjected.Token(Token = "0x6001A1F")]
		[Cpp2IlInjected.Address(RVA = "0x13FC388", Offset = "0x13FC388", VA = "0x13FC388")]
		get
		{
			return default(LightMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6001A20")]
		[Cpp2IlInjected.Address(RVA = "0x13FC404", Offset = "0x13FC404", VA = "0x13FC404")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000363")]
	private static LightingEngine NewEngine
	{
		[Cpp2IlInjected.Token(Token = "0x6001A21")]
		[Cpp2IlInjected.Address(RVA = "0x13FC484", Offset = "0x13FC484", VA = "0x13FC484")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000364")]
	private static LegacyLighting LegacyEngine
	{
		[Cpp2IlInjected.Token(Token = "0x6001A22")]
		[Cpp2IlInjected.Address(RVA = "0x13FC504", Offset = "0x13FC504", VA = "0x13FC504")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000365")]
	private static ILightingEngine _activeEngine
	{
		[Cpp2IlInjected.Token(Token = "0x6001A23")]
		[Cpp2IlInjected.Address(RVA = "0x13FC584", Offset = "0x13FC584", VA = "0x13FC584")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001A24")]
		[Cpp2IlInjected.Address(RVA = "0x13FC604", Offset = "0x13FC604", VA = "0x13FC604")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000366")]
	public static float GlobalBrightness
	{
		[Cpp2IlInjected.Token(Token = "0x6001A25")]
		[Cpp2IlInjected.Address(RVA = "0x13FC684", Offset = "0x13FC684", VA = "0x13FC684")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6001A26")]
		[Cpp2IlInjected.Address(RVA = "0x13FC6FC", Offset = "0x13FC6FC", VA = "0x13FC6FC")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000367")]
	public static LightMode Mode
	{
		[Cpp2IlInjected.Token(Token = "0x6001A28")]
		[Cpp2IlInjected.Address(RVA = "0x13FC880", Offset = "0x13FC880", VA = "0x13FC880")]
		get
		{
			return default(LightMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6001A29")]
		[Cpp2IlInjected.Address(RVA = "0x13FC8F0", Offset = "0x13FC8F0", VA = "0x13FC8F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000368")]
	public static bool NotRetro
	{
		[Cpp2IlInjected.Token(Token = "0x6001A2A")]
		[Cpp2IlInjected.Address(RVA = "0x13FCAB8", Offset = "0x13FCAB8", VA = "0x13FCAB8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000369")]
	public static bool UsingNewLighting
	{
		[Cpp2IlInjected.Token(Token = "0x6001A2B")]
		[Cpp2IlInjected.Address(RVA = "0x13FCB30", Offset = "0x13FCB30", VA = "0x13FCB30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700036A")]
	public static bool UpdateEveryFrame
	{
		[Cpp2IlInjected.Token(Token = "0x6001A2C")]
		[Cpp2IlInjected.Address(RVA = "0x13FCBAC", Offset = "0x13FCBAC", VA = "0x13FCBAC")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6001A27")]
	[Cpp2IlInjected.Address(RVA = "0x13FC784", Offset = "0x13FC784", VA = "0x13FC784")]
	public static void ResetLighting()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001A2D")]
	[Cpp2IlInjected.Address(RVA = "0x13FCBB4", Offset = "0x13FCBB4", VA = "0x13FCBB4")]
	public static void Initialize(bool resized = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001A2E")]
	[Cpp2IlInjected.Address(RVA = "0x13FCCE4", Offset = "0x13FCCE4", VA = "0x13FCCE4")]
	public static void LightTiles(int firstX, int lastX, int firstY, int lastY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001A2F")]
	[Cpp2IlInjected.Address(RVA = "0x13FCEB0", Offset = "0x13FCEB0", VA = "0x13FCEB0")]
	private static void UpdateGlobalBrightness()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001A30")]
	[Cpp2IlInjected.Address(RVA = "0x13FD050", Offset = "0x13FD050", VA = "0x13FD050")]
	public static float Brightness(int x, int y)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6001A31")]
	[Cpp2IlInjected.Address(RVA = "0x13FD1F0", Offset = "0x13FD1F0", VA = "0x13FD1F0")]
	public static Vector3 GetSubLight(Vector2 position)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6001A32")]
	[Cpp2IlInjected.Address(RVA = "0x13FD68C", Offset = "0x13FD68C", VA = "0x13FD68C")]
	public static void AddLight(Vector2 position, Vector3 rgb)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001A33")]
	[Cpp2IlInjected.Address(RVA = "0x13FD9B0", Offset = "0x13FD9B0", VA = "0x13FD9B0")]
	public static void AddLight(Vector2 position, float r, float g, float b)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001A34")]
	[Cpp2IlInjected.Address(RVA = "0x13FDA78", Offset = "0x13FDA78", VA = "0x13FDA78")]
	public static void AddLight(int i, int j, int torchID, float lightAmount)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001A35")]
	[Cpp2IlInjected.Address(RVA = "0x13FDCD8", Offset = "0x13FDCD8", VA = "0x13FDCD8")]
	public static void AddLight(Vector2 position, int torchID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001A36")]
	[Cpp2IlInjected.Address(RVA = "0x13FD758", Offset = "0x13FD758", VA = "0x13FD758")]
	public static void AddLight(int i, int j, float r, float g, float b)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001A37")]
	[Cpp2IlInjected.Address(RVA = "0x13FDE00", Offset = "0x13FDE00", VA = "0x13FDE00")]
	public static void NextLightMode()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001A38")]
	[Cpp2IlInjected.Address(RVA = "0x13FDF84", Offset = "0x13FDF84", VA = "0x13FDF84")]
	public static void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001A39")]
	[Cpp2IlInjected.Address(RVA = "0x13FE070", Offset = "0x13FE070", VA = "0x13FE070")]
	public static Color GetColor(Point tileCoords)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6001A3A")]
	[Cpp2IlInjected.Address(RVA = "0x13FE2D0", Offset = "0x13FE2D0", VA = "0x13FE2D0")]
	public static Color GetColor(Point tileCoords, Color originalColor)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6001A3B")]
	[Cpp2IlInjected.Address(RVA = "0x13FE4B0", Offset = "0x13FE4B0", VA = "0x13FE4B0")]
	public static Color GetColor(int x, int y, Color oldColor)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6001A3C")]
	[Cpp2IlInjected.Address(RVA = "0x13FE690", Offset = "0x13FE690", VA = "0x13FE690")]
	public static Color GetColorClamped(int x, int y, Color oldColor)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6001A3D")]
	[Cpp2IlInjected.Address(RVA = "0x13FE8E8", Offset = "0x13FE8E8", VA = "0x13FE8E8")]
	public static Vector3 GetColorVector3(int x, int y)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6001A3E")]
	[Cpp2IlInjected.Address(RVA = "0x13FEAD4", Offset = "0x13FEAD4", VA = "0x13FEAD4")]
	public static LightMap GetLightMap(out Rectangle lightMapRegion)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001A3F")]
	[Cpp2IlInjected.Address(RVA = "0x13FEBC8", Offset = "0x13FEBC8", VA = "0x13FEBC8")]
	public static Rectangle GetScanRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x6001A40")]
	[Cpp2IlInjected.Address(RVA = "0x13FECBC", Offset = "0x13FECBC", VA = "0x13FECBC")]
	public static Color GetColor(int x, int y)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6001A41")]
	[Cpp2IlInjected.Address(RVA = "0x13FEF10", Offset = "0x13FEF10", VA = "0x13FEF10")]
	public static void GetColor9Slice(int centerX, int centerY, ref Color[] slices)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001A42")]
	[Cpp2IlInjected.Address(RVA = "0x13FF224", Offset = "0x13FF224", VA = "0x13FF224")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x38FD00", Offset = "0x38FD00")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x38FD00", Offset = "0x38FD00")]
	public static void GetColor9Slice(int x, int y, ref Vector3[] slices)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001A43")]
	[Cpp2IlInjected.Address(RVA = "0x13FFD5C", Offset = "0x13FFD5C", VA = "0x13FFD5C")]
	public static void GetCornerColors(int centerX, int centerY, out VertexColors vertices, float scale = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001A44")]
	[Cpp2IlInjected.Address(RVA = "0x140066C", Offset = "0x140066C", VA = "0x140066C")]
	public static void GetColor4Slice(int centerX, int centerY, ref Color[] slices)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001A45")]
	[Cpp2IlInjected.Address(RVA = "0x14016EC", Offset = "0x14016EC", VA = "0x14016EC")]
	public static void GetColor4Slice(int x, int y, ref Vector3[] slices)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001A46")]
	[Cpp2IlInjected.Address(RVA = "0x14021C8", Offset = "0x14021C8", VA = "0x14021C8")]
	public Lighting()
	{
	}
}
