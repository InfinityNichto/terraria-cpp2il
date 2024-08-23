using System;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Diagnostics
{
	// Token: 0x02000088 RID: 136
	[global::Cpp2ILInjected.Token(Token = "0x20000E3")]
	public class Stopwatch
	{
		// Token: 0x06000490 RID: 1168
		[global::Cpp2ILInjected.Token(Token = "0x6000530")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC5884", Offset = "0x1EC5884", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Threading.ThreadUtilities", Member = "HighPrecisionSleep", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public static extern long GetTimestamp();

		// Token: 0x06000491 RID: 1169 RVA: 0x00003B3F File Offset: 0x00001D3F
		[global::Cpp2ILInjected.Token(Token = "0x6000531")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECC340", Offset = "0x1ECC340", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 30)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Stopwatch()
		{
			throw null;
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000492 RID: 1170 RVA: 0x00003B42 File Offset: 0x00001D42
		[global::Cpp2ILInjected.Token(Token = "0x170000FF")]
		public TimeSpan Elapsed
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000532")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ECC348", Offset = "0x1ECC348", Length = "0xF8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "DoUpdateInWorld", MemberParameters = new object[] { typeof(Stopwatch) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "DrawBackground", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "OldDrawBackground", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "DrawLiquid", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(int),
				typeof(float),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "DrawBlack", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.TimeLogger", Member = "NewDrawFrame", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.TimeLogger", Member = "DetailedDrawReset", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.TimeLogger", Member = "DetailedDrawTime", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Utilities.MultiTimer", Member = "Record", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.PlayerFileData", Member = "GetPlayTime", ReturnType = typeof(TimeSpan))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.PlayerFileData", Member = "UpdatePlayTimerAndKeepState", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.PlayerFileData", Member = "StopPlayTimer", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Graphics.Light.LegacyLighting", Member = "PreRenderPhase", MemberParameters = new object[] { "Microsoft.Xna.Framework.Rectangle" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Graphics.Light.LightingEngine", Member = "ProcessArea", MemberParameters = new object[] { "Microsoft.Xna.Framework.Rectangle" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Drawing.TileDrawing", Member = "Draw", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(bool),
				typeof(bool),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Drawing.WallDrawing", Member = "DrawWalls", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Utilities.MultiTimer", Member = "Record", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Stopwatch), Member = "get_ElapsedMilliseconds", ReturnType = typeof(long))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 21)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = "get_ElapsedTicks", ReturnType = typeof(long))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "FromTicks", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(TimeSpan))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000493 RID: 1171 RVA: 0x00003B45 File Offset: 0x00001D45
		[global::Cpp2ILInjected.Token(Token = "0x17000100")]
		public long ElapsedMilliseconds
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000533")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ECC4B0", Offset = "0x1ECC4B0", Length = "0x11C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "DoUpdate", MemberParameters = new object[] { "Microsoft.Xna.Framework.GameTime" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "DoUpdate_AutoSave", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "DrawSplash", MemberParameters = new object[] { "Microsoft.Xna.Framework.GameTime" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "DoDraw", MemberParameters = new object[] { "Microsoft.Xna.Framework.GameTime" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen", Member = "EveryTileFrame", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.WorldFile", Member = "ValidateWorld", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.LootSimulation.LootSimulator", Member = "Run", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UnitySynchronizationContext", Member = "ExecutePendingTasks", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = "get_ElapsedTicks", ReturnType = typeof(long))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = "get_Elapsed", ReturnType = typeof(TimeSpan))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalMilliseconds", ReturnType = typeof(double))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000494 RID: 1172 RVA: 0x00003B48 File Offset: 0x00001D48
		[global::Cpp2ILInjected.Token(Token = "0x17000101")]
		public long ElapsedTicks
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000534")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ECC440", Offset = "0x1ECC440", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Stopwatch), Member = "get_Elapsed", ReturnType = typeof(TimeSpan))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Stopwatch), Member = "get_ElapsedMilliseconds", ReturnType = typeof(long))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x00003B4B File Offset: 0x00001D4B
		[global::Cpp2ILInjected.Token(Token = "0x17000102")]
		public bool IsRunning
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000535")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ECC5CC", Offset = "0x1ECC5CC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x00003B4E File Offset: 0x00001D4E
		[global::Cpp2ILInjected.Token(Token = "0x6000536")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECC5D4", Offset = "0x1ECC5D4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "startDedInputCallBack", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "DoUpdate_AutoSave", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldBuilding.WorldGenerator", Member = "GenerateWorld", MemberParameters = new object[] { "Terraria.WorldBuilding.GenerationProgress" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Utilities.MultiTimer", Member = "Start", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.PlayerFileData", Member = "UpdatePlayTimerAndKeepState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.PlayerFileData", Member = "StopPlayTimer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Graphics.Light.LightingEngine", Member = "ProcessArea", MemberParameters = new object[] { "Microsoft.Xna.Framework.Rectangle" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Utilities.MultiTimer", Member = "Start", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Utilities.MultiTimer", Member = "Record", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		public void Reset()
		{
			throw null;
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00003B51 File Offset: 0x00001D51
		[global::Cpp2ILInjected.Token(Token = "0x6000537")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECC5E0", Offset = "0x1ECC5E0", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 30)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void Start()
		{
			throw null;
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00003B54 File Offset: 0x00001D54
		[global::Cpp2ILInjected.Token(Token = "0x6000538")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECC648", Offset = "0x1ECC648", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "DoUpdate", MemberParameters = new object[] { "Microsoft.Xna.Framework.GameTime" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "DoUpdate_AutoSave", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "DrawSplash", MemberParameters = new object[] { "Microsoft.Xna.Framework.GameTime" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.TimeLogger", Member = "EndDrawFrame", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldSections", Member = "GetNextMapDraw", MemberParameters = new object[]
		{
			"Microsoft.Xna.Framework.Vector2",
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.LootSimulation.LootSimulator", Member = "Run", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Utilities.MultiTimer", Member = "Record", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Utilities.MultiTimer", Member = "StopAndPrint", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void Stop()
		{
			throw null;
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00003B57 File Offset: 0x00001D57
		[global::Cpp2ILInjected.Token(Token = "0x6000539")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECC6C0", Offset = "0x1ECC6C0", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "DoUpdate", MemberParameters = new object[] { "Microsoft.Xna.Framework.GameTime" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.TimeLogger", Member = "NewDrawFrame", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Utilities.MultiTimer", Member = "Record", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void Restart()
		{
			throw null;
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00003B5A File Offset: 0x00001D5A
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600053A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECC720", Offset = "0x1ECC720", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static Stopwatch()
		{
			throw null;
		}

		// Token: 0x040002D3 RID: 723
		[global::Cpp2ILInjected.Token(Token = "0x4000428")]
		public static readonly long Frequency;

		// Token: 0x040002D4 RID: 724
		[global::Cpp2ILInjected.Token(Token = "0x4000429")]
		public static readonly bool IsHighResolution;

		// Token: 0x040002D5 RID: 725
		[global::Cpp2ILInjected.Token(Token = "0x400042A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private long elapsed;

		// Token: 0x040002D6 RID: 726
		[global::Cpp2ILInjected.Token(Token = "0x400042B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private long started;

		// Token: 0x040002D7 RID: 727
		[global::Cpp2ILInjected.Token(Token = "0x400042C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private bool is_running;
	}
}
