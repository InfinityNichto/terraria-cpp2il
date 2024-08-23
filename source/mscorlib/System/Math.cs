using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Text;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000A6 RID: 166
	[global::Cpp2ILInjected.Token(Token = "0x20000D6")]
	public static class Math
	{
		// Token: 0x06000742 RID: 1858 RVA: 0x00015A6A File Offset: 0x00013C6A
		[global::Cpp2ILInjected.Token(Token = "0x60007E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C35B90", Offset = "0x1C35B90", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Math), Member = "ThrowAbsOverflow", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(256)]
		public static int Abs(int value)
		{
			throw null;
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x00015A6D File Offset: 0x00013C6D
		[global::System.Diagnostics.StackTraceHidden]
		[global::Cpp2ILInjected.Token(Token = "0x60007E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C35BEC", Offset = "0x1C35BEC", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Math), Member = "Abs", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static void ThrowAbsOverflow()
		{
			throw null;
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x00015A70 File Offset: 0x00013C70
		[global::Cpp2ILInjected.Token(Token = "0x60007E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C35C38", Offset = "0x1C35C38", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.IPAddressParser", Member = "FormatIPv4AddressNumber", MemberParameters = new object[]
		{
			typeof(int),
			"System.Char*",
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static int DivRem(int a, int b, out int result)
		{
			throw null;
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x00015A73 File Offset: 0x00013C73
		[global::Cpp2ILInjected.Token(Token = "0x60007EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C35C4C", Offset = "0x1C35C4C", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Math), Member = "ThrowMinMaxException", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T", "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		[MethodImpl(256)]
		public static int Clamp(int value, int min, int max)
		{
			throw null;
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x00015A76 File Offset: 0x00013C76
		[global::Cpp2ILInjected.Token(Token = "0x60007EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C35CF0", Offset = "0x1C35CF0", Length = "0x27C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.MathHelper", Member = "WrapAngle", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "DrawProjDirect", MemberParameters = new object[]
		{
			"Terraria.Projectile",
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "DrawBackground", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "OldDrawBackground", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "DrawSurfaceBG", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "DrawSurfaceBG_BackMountainsStep1", MemberParameters = new object[]
		{
			typeof(double),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "DrawSurfaceBG_Mushroom", MemberParameters = new object[]
		{
			typeof(double),
			typeof(float),
			typeof(int),
			"System.Int32[]"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "DrawSurfaceBG_Crimson", MemberParameters = new object[]
		{
			typeof(double),
			typeof(float),
			typeof(int),
			"System.Int32[]"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "DrawSurfaceBG_Snow", MemberParameters = new object[]
		{
			typeof(double),
			typeof(float),
			typeof(int),
			"System.Int32[]"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "DrawSurfaceBG_Hallow", MemberParameters = new object[]
		{
			typeof(double),
			typeof(float),
			typeof(int),
			"System.Int32[]"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "DrawSurfaceBG_GoodEvilDesert", MemberParameters = new object[]
		{
			typeof(double),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "DrawSurfaceBG_Jungle", MemberParameters = new object[]
		{
			typeof(double),
			typeof(float),
			typeof(int),
			"System.Int32[]"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "DrawSurfaceBG_Desert", MemberParameters = new object[]
		{
			typeof(double),
			typeof(float),
			typeof(int),
			"System.Int32[]"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "DrawSurfaceBG_Corrupt", MemberParameters = new object[]
		{
			typeof(double),
			typeof(float),
			typeof(int),
			"System.Int32[]"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "DrawSurfaceBG_Forest", MemberParameters = new object[]
		{
			typeof(double),
			typeof(float),
			typeof(int),
			"System.Int32[]"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "DoDraw", MemberParameters = new object[] { "Microsoft.Xna.Framework.GameTime" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "UpdateServer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Projectile", Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Wiring", Member = "UpdateMech", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 67)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Math), Member = "Sign", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public static double IEEERemainder(double x, double y)
		{
			throw null;
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x00015A79 File Offset: 0x00013C79
		[global::Cpp2ILInjected.Token(Token = "0x60007EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C35FE4", Offset = "0x1C35FE4", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Utils", Member = "RandomConsecutive", MemberParameters = new object[]
		{
			typeof(double),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Mathf", Member = "Log", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleScaleWithScreenSize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static double Log(double a, double newBase)
		{
			throw null;
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x00015A7C File Offset: 0x00013C7C
		[global::System.Runtime.Versioning.NonVersionable]
		[global::Cpp2ILInjected.Token(Token = "0x60007ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C36134", Offset = "0x1C36134", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.Color", Member = "GetBrightness", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.Color", Member = "GetSaturation", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "DrawStar", MemberParameters = new object[]
		{
			"SceneArea&",
			typeof(float),
			"Microsoft.Xna.Framework.Graphics.Color",
			typeof(int),
			"Terraria.Star",
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Map.WorldMap", Member = "UpdateLighting", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(byte)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zlib.Tree", Member = "build_tree", MemberParameters = new object[] { "Ionic.Zlib.DeflateManager" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		public static byte Max(byte val1, byte val2)
		{
			throw null;
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x00015A7F File Offset: 0x00013C7F
		[global::Cpp2ILInjected.Token(Token = "0x60007EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C36144", Offset = "0x1C36144", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen", Member = "WavyCaverer", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(double),
			typeof(double),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldBuilding.Modifiers.RadialDither", Member = "Apply", MemberParameters = new object[]
		{
			"Microsoft.Xna.Framework.Point",
			typeof(int),
			typeof(int),
			"System.Object[]"
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Utilities.MultiTimer.TimerData", Member = "AddTick", MemberParameters = new object[] { typeof(double) }, ReturnType = "Terraria.Utilities.MultiTimer.TimerData")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.UserInterface", Member = "ResetState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.UserInterface", Member = "Update", MemberParameters = new object[] { "Microsoft.Xna.Framework.GameTime" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Biomes.GraniteBiome", Member = "SimulatePressure", MemberParameters = new object[] { "Microsoft.Xna.Framework.Rectangle&" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Biomes.GraniteBiome", Member = "PlaceGranite", MemberParameters = new object[] { "Microsoft.Xna.Framework.Point", "Microsoft.Xna.Framework.Rectangle" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Biomes.MarbleBiome", Member = "Place", MemberParameters = new object[] { "Microsoft.Xna.Framework.Point", "Terraria.WorldBuilding.StructureMap" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Biomes.TerrainPass", Member = "ApplyPass", MemberParameters = new object[] { "Terraria.WorldBuilding.GenerationProgress", "Terraria.IO.GameConfiguration" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Utilities.MultiTimer.TimerData", Member = "AddTick", MemberParameters = new object[] { typeof(double) }, ReturnType = "ReLogic.Utilities.MultiTimer.TimerData")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.MathUtils", Member = "Max", MemberParameters = new object[] { "System.Nullable`1<Double>", "System.Nullable`1<Double>" }, ReturnType = "System.Nullable`1<Double>")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static double Max(double val1, double val2)
		{
			throw null;
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x00015A82 File Offset: 0x00013C82
		[global::System.Runtime.Versioning.NonVersionable]
		[global::Cpp2ILInjected.Token(Token = "0x60007EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C361BC", Offset = "0x1C361BC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 127)]
		public static int Max(int val1, int val2)
		{
			throw null;
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x00015A85 File Offset: 0x00013C85
		[global::System.Runtime.Versioning.NonVersionable]
		[global::Cpp2ILInjected.Token(Token = "0x60007F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C361C8", Offset = "0x1C361C8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.PopupText", Member = "AddToCoinValue", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipFile", Member = "ReadIntoInstance", MemberParameters = new object[] { "Ionic.Zip.ZipFile" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public static long Max(long val1, long val2)
		{
			throw null;
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x00015A88 File Offset: 0x00013C88
		[global::Cpp2ILInjected.Token(Token = "0x60007F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C361D4", Offset = "0x1C361D4", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 125)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static float Max(float val1, float val2)
		{
			throw null;
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x00015A8B File Offset: 0x00013C8B
		[global::System.CLSCompliant(false)]
		[global::System.Runtime.Versioning.NonVersionable]
		[global::Cpp2ILInjected.Token(Token = "0x60007F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3624C", Offset = "0x1C3624C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.MessageBuffer", Member = "ProcessData", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static ushort Max(ushort val1, ushort val2)
		{
			throw null;
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x00015A8E File Offset: 0x00013C8E
		[global::System.Runtime.Versioning.NonVersionable]
		[global::Cpp2ILInjected.Token(Token = "0x60007F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3625C", Offset = "0x1C3625C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.Color", Member = "GetBrightness", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.Color", Member = "GetSaturation", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public static byte Min(byte val1, byte val2)
		{
			throw null;
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x00015A91 File Offset: 0x00013C91
		[global::Cpp2ILInjected.Token(Token = "0x60007F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3626C", Offset = "0x1C3626C", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Projectile", Member = "AI_067_TigerSpecialAttack", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_45", MemberParameters = new object[] { "Terraria.WorldBuilding.GenerationProgress", "Terraria.IO.GameConfiguration" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen", Member = "WavyCaverer", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(double),
			typeof(double),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldBuilding.Modifiers.RadialDither", Member = "Apply", MemberParameters = new object[]
		{
			"Microsoft.Xna.Framework.Point",
			typeof(int),
			typeof(int),
			"System.Object[]"
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldBuilding.Shapes.Slime", Member = "Perform", MemberParameters = new object[] { "Microsoft.Xna.Framework.Point", "Terraria.WorldBuilding.GenAction" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Utilities.MultiTimer.TimerData", Member = "AddTick", MemberParameters = new object[] { typeof(double) }, ReturnType = "Terraria.Utilities.MultiTimer.TimerData")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Biomes.TerrainPass", Member = "ApplyPass", MemberParameters = new object[] { "Terraria.WorldBuilding.GenerationProgress", "Terraria.IO.GameConfiguration" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Utilities.MultiTimer.TimerData", Member = "AddTick", MemberParameters = new object[] { typeof(double) }, ReturnType = "ReLogic.Utilities.MultiTimer.TimerData")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static double Min(double val1, double val2)
		{
			throw null;
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x00015A94 File Offset: 0x00013C94
		[global::System.Runtime.Versioning.NonVersionable]
		[global::Cpp2ILInjected.Token(Token = "0x60007F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C362E4", Offset = "0x1C362E4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 174)]
		public static int Min(int val1, int val2)
		{
			throw null;
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x00015A97 File Offset: 0x00013C97
		[global::System.Runtime.Versioning.NonVersionable]
		[global::Cpp2ILInjected.Token(Token = "0x60007F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C362F0", Offset = "0x1C362F0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.PopupText", Member = "AddToCoinValue", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Threading.Timer.Scheduler", Member = "RunSchedulerLoop", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.UnmanagedMemoryStream), Member = "ReadCore", MemberParameters = new object[] { typeof(global::System.Span<byte>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Stream), Member = "GetCopyBufferSize", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient", Member = "OpenFileInternal", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(string),
			typeof(ref global::System.IO.FileStream),
			"System.Byte[]&",
			"System.Byte[]&",
			"System.Byte[]&"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient", Member = "UploadDataAsync", MemberParameters = new object[]
		{
			"System.Uri",
			typeof(string),
			"System.Byte[]",
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient", Member = "UploadValuesAsync", MemberParameters = new object[]
		{
			"System.Uri",
			typeof(string),
			"System.Collections.Specialized.NameValueCollection",
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FixedSizeReadStream.<ProcessReadAsync>d__5", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpListenerRequest", Member = "FlushInput", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.RequestStream", Member = "FillFromBuffer", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.RequestStream", Member = "BeginRead", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int),
			typeof(int),
			typeof(global::System.AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(global::System.IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.ChunkedMemoryStream", Member = "AppendChunk", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		public static long Min(long val1, long val2)
		{
			throw null;
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x00015A9A File Offset: 0x00013C9A
		[global::Cpp2ILInjected.Token(Token = "0x60007F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C362FC", Offset = "0x1C362FC", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 83)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static float Min(float val1, float val2)
		{
			throw null;
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x00015A9D File Offset: 0x00013C9D
		[global::System.Runtime.Versioning.NonVersionable]
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60007F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C36374", Offset = "0x1C36374", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Map.MapHelper.BitReader", Member = "Read", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.TimerThread.Timer", Member = "get_TimeRemaining", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.TimerThread", Member = "ThreadProc", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public static uint Min(uint val1, uint val2)
		{
			throw null;
		}

		// Token: 0x06000754 RID: 1876
		[global::Cpp2ILInjected.Token(Token = "0x60007F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C36380", Offset = "0x1C36380", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public static extern double Round(double a);

		// Token: 0x06000755 RID: 1877 RVA: 0x00015AA0 File Offset: 0x00013CA0
		[global::Cpp2ILInjected.Token(Token = "0x60007FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C36404", Offset = "0x1C36404", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(256)]
		public static double Round(double value, int digits)
		{
			throw null;
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x00015AA3 File Offset: 0x00013CA3
		[global::Cpp2ILInjected.Token(Token = "0x60007FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3646C", Offset = "0x1C3646C", Length = "0x28C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Minecart", Member = "TrackCollision", MemberParameters = new object[]
		{
			"Terraria.Player",
			"Microsoft.Xna.Framework.Vector2&",
			"Microsoft.Xna.Framework.Vector2&",
			"Microsoft.Xna.Framework.Vector2&",
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(int),
			typeof(bool),
			"Terraria.Mount.MountDelegatesData"
		}, ReturnType = "Terraria.BitsByte")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Math), Member = "Sign", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public static double Round(double value, int digits, global::System.MidpointRounding mode)
		{
			throw null;
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x00015AA6 File Offset: 0x00013CA6
		[global::Cpp2ILInjected.Token(Token = "0x60007FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C35F6C", Offset = "0x1C35F6C", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Math), Member = "IEEERemainder", MemberParameters = new object[]
		{
			typeof(double),
			typeof(double)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Math), Member = "Round", MemberParameters = new object[]
		{
			typeof(double),
			typeof(int),
			typeof(global::System.MidpointRounding)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArithmeticException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static int Sign(double value)
		{
			throw null;
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x00015AA9 File Offset: 0x00013CA9
		[global::Cpp2ILInjected.Token(Token = "0x60007FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C366FC", Offset = "0x1C366FC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "DrawProjDirect", MemberParameters = new object[]
		{
			"Terraria.Projectile",
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "DrawInterface_4_Ruler", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.NPC", Member = "AI_123_Deerclops_TryMakingSpike_FindBestY", MemberParameters = new object[]
		{
			"Microsoft.Xna.Framework.Point&",
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.NPC", Member = "AI_007_TownEntities_GetWalkPrediction", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(int),
			typeof(int),
			typeof(ref bool),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.NPC", Member = "AI_107_ImprovedWalkers", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Player", Member = "HorizontalMovement", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Player", Member = "CanParryAgainst", MemberParameters = new object[] { "Microsoft.Xna.Framework.Rectangle", "Microsoft.Xna.Framework.Rectangle", "Microsoft.Xna.Framework.Vector2" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Projectile", Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Collision", Member = "CanHitLine", MemberParameters = new object[]
		{
			"Microsoft.Xna.Framework.Vector2",
			typeof(int),
			typeof(int),
			"Microsoft.Xna.Framework.Vector2",
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Collision", Member = "TupleHitLine", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			"System.Collections.Generic.List`1<Int32>",
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Collision", Member = "TupleHitLineWall", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Collision", Member = "StepConveyorBelt", MemberParameters = new object[]
		{
			"Terraria.Entity",
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Mount", Member = "GetMinecartMechPoint", MemberParameters = new object[]
		{
			"Terraria.Player",
			typeof(int),
			typeof(int)
		}, ReturnType = "Microsoft.Xna.Framework.Vector2")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Wiring", Member = "MassWireOperationInner", MemberParameters = new object[]
		{
			"Terraria.Player",
			"Microsoft.Xna.Framework.Point",
			"Microsoft.Xna.Framework.Point",
			"Microsoft.Xna.Framework.Vector2",
			typeof(bool),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen", Member = "GrowPalmTree", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 25)]
		public static int Sign(int value)
		{
			throw null;
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x00015AAC File Offset: 0x00013CAC
		[global::Cpp2ILInjected.Token(Token = "0x60007FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3670C", Offset = "0x1C3670C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Threading.Timer.TimerComparer", Member = "Compare", MemberParameters = new object[]
		{
			typeof(global::System.Threading.Timer),
			typeof(global::System.Threading.Timer)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static int Sign(long value)
		{
			throw null;
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x00015AAF File Offset: 0x00013CAF
		[global::Cpp2ILInjected.Token(Token = "0x60007FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C36720", Offset = "0x1C36720", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 174)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArithmeticException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static int Sign(float value)
		{
			throw null;
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x00015AB2 File Offset: 0x00013CB2
		[global::Cpp2ILInjected.Token(Token = "0x6000800")]
		[global::Cpp2ILInjected.Address(RVA = "0x15905B4", Offset = "0x15905B4", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Math), Member = "Clamp", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static void ThrowMinMaxException<T>(T min, T max)
		{
			throw null;
		}

		// Token: 0x0600075C RID: 1884
		[global::Cpp2ILInjected.Token(Token = "0x6000801")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C36798", Offset = "0x1C36798", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(4096)]
		public static extern double Abs(double value);

		// Token: 0x0600075D RID: 1885
		[global::Cpp2ILInjected.Token(Token = "0x6000802")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C367A0", Offset = "0x1C367A0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(4096)]
		public static extern float Abs(float value);

		// Token: 0x0600075E RID: 1886
		[global::Cpp2ILInjected.Token(Token = "0x6000803")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C367A8", Offset = "0x1C367A8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public static extern double Acos(double d);

		// Token: 0x0600075F RID: 1887
		[global::Cpp2ILInjected.Token(Token = "0x6000804")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C367AC", Offset = "0x1C367AC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public static extern double Atan(double d);

		// Token: 0x06000760 RID: 1888
		[global::Cpp2ILInjected.Token(Token = "0x6000805")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C367B0", Offset = "0x1C367B0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public static extern double Atan2(double y, double x);

		// Token: 0x06000761 RID: 1889
		[global::Cpp2ILInjected.Token(Token = "0x6000806")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C367B4", Offset = "0x1C367B4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(4096)]
		public static extern double Ceiling(double a);

		// Token: 0x06000762 RID: 1890
		[global::Cpp2ILInjected.Token(Token = "0x6000807")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C367BC", Offset = "0x1C367BC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public static extern double Cos(double d);

		// Token: 0x06000763 RID: 1891
		[global::Cpp2ILInjected.Token(Token = "0x6000808")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C367C0", Offset = "0x1C367C0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(4096)]
		public static extern double Floor(double d);

		// Token: 0x06000764 RID: 1892
		[global::Cpp2ILInjected.Token(Token = "0x6000809")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C367C8", Offset = "0x1C367C8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public static extern double Log(double d);

		// Token: 0x06000765 RID: 1893
		[global::Cpp2ILInjected.Token(Token = "0x600080A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C367CC", Offset = "0x1C367CC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "UpdateAudio", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "DrawNPCDirect", MemberParameters = new object[]
		{
			"Microsoft.Xna.Framework.Graphics.SpriteBatch",
			"Terraria.NPC",
			typeof(bool),
			"Microsoft.Xna.Framework.Vector2"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "DrawNPCDirect", MemberParameters = new object[]
		{
			"Microsoft.Xna.Framework.Graphics.SpriteBatch",
			"Terraria.NPC",
			typeof(bool),
			"Microsoft.Xna.Framework.Vector2",
			"Terraria.Graphics.Light.LightMap",
			"Microsoft.Xna.Framework.Rectangle&"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "DrawMurderAurora", MemberParameters = new object[] { "Terraria.Projectile" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "DrawSunAndMoon", MemberParameters = new object[]
		{
			"Terraria.Main.SceneArea",
			"Microsoft.Xna.Framework.Graphics.Color",
			"Microsoft.Xna.Framework.Graphics.Color",
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.NPC", Member = "LadyBugLuck", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Player", Member = "ApplyRangeCompensation", MemberParameters = new object[]
		{
			typeof(float),
			"Microsoft.Xna.Framework.Vector2",
			"Microsoft.Xna.Framework.Vector2"
		}, ReturnType = "Microsoft.Xna.Framework.Vector2")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Rain", Member = "NewRain", MemberParameters = new object[] { "Microsoft.Xna.Framework.Vector2", "Microsoft.Xna.Framework.Vector2" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen", Member = "ShimmerCleanUp", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen", Member = "ShimmerRemoveWater", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen", Member = "ShimmerMakeBiome", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Map.MapHelper.RunLengthEncodingCompressionProfile", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(uint)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameInput.LockOnHelper", Member = "get_PredictedPosition", ReturnType = "Microsoft.Xna.Framework.Vector2")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Utilities.Vector2D", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "FormatCustomized", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.TimeSpan),
			typeof(global::System.Text.StringBuilder)
		}, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.TimeSpanParse), Member = "Pow10", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Mathf", Member = "Pow", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 31)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public static extern double Pow(double x, double y);

		// Token: 0x06000766 RID: 1894
		[global::Cpp2ILInjected.Token(Token = "0x600080B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C367D0", Offset = "0x1C367D0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public static extern double Sin(double a);

		// Token: 0x06000767 RID: 1895
		[global::Cpp2ILInjected.Token(Token = "0x600080C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C367D4", Offset = "0x1C367D4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(4096)]
		public static extern double Sqrt(double d);

		// Token: 0x06000768 RID: 1896
		[global::Cpp2ILInjected.Token(Token = "0x600080D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C367DC", Offset = "0x1C367DC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public static extern double Tan(double a);

		// Token: 0x06000769 RID: 1897
		[global::Cpp2ILInjected.Token(Token = "0x600080E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C366F8", Offset = "0x1C366F8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private unsafe static extern double ModF(double x, double* intptr);

		// Token: 0x0600076A RID: 1898 RVA: 0x00015AB5 File Offset: 0x00013CB5
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600080F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C367E0", Offset = "0x1C367E0", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static Math()
		{
			throw null;
		}

		// Token: 0x04000218 RID: 536
		[global::Cpp2ILInjected.Token(Token = "0x4000365")]
		private static double doubleRoundLimit;

		// Token: 0x04000219 RID: 537
		[global::Cpp2ILInjected.Token(Token = "0x4000366")]
		private static double[] roundPower10Double;
	}
}
