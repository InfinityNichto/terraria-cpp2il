using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.Drawing;

namespace Terraria.Graphics.Capture
{
	// Token: 0x02000507 RID: 1287
	[global::Cpp2ILInjected.Token(Token = "0x200076D")]
	public class CaptureManager : IDisposable
	{
		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x060037BC RID: 14268 RVA: 0x0002BF5B File Offset: 0x0002A15B
		[global::Cpp2ILInjected.Token(Token = "0x1700078F")]
		public bool IsCapturing
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003E58")]
			[global::Cpp2ILInjected.Address(RVA = "0x14B6324", Offset = "0x14B6324", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdate", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060037BD RID: 14269 RVA: 0x0002BF5E File Offset: 0x0002A15E
		[global::Cpp2ILInjected.Token(Token = "0x6003E59")]
		[global::Cpp2ILInjected.Address(RVA = "0x14B632C", Offset = "0x14B632C", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CaptureManager), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public CaptureManager()
		{
			throw null;
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x060037BE RID: 14270 RVA: 0x0002BF61 File Offset: 0x0002A161
		// (set) Token: 0x060037BF RID: 14271 RVA: 0x0002BF64 File Offset: 0x0002A164
		[global::Cpp2ILInjected.Token(Token = "0x17000790")]
		public bool Active
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003E5A")]
			[global::Cpp2ILInjected.Address(RVA = "0x14B6390", Offset = "0x14B6390", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ToggleInv", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ToggleCreativeMenu", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "TryInterruptingItemUsage", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheck_ManageRightClickFeatures", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "Draw", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(bool),
				typeof(bool),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003E5B")]
			[global::Cpp2ILInjected.Address(RVA = "0x14B639C", Offset = "0x14B639C", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ToggleInv", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ToggleCreativeMenu", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CaptureInterface), Member = "ToggleCamera", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x060037C0 RID: 14272 RVA: 0x0002BF67 File Offset: 0x0002A167
		[global::Cpp2ILInjected.Token(Token = "0x17000791")]
		public bool UsingMap
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003E5C")]
			[global::Cpp2ILInjected.Address(RVA = "0x14B642C", Offset = "0x14B642C", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CaptureInterface), Member = "UsingMap", ReturnType = typeof(bool))]
			get
			{
				throw null;
			}
		}

		// Token: 0x060037C1 RID: 14273 RVA: 0x0002BF6A File Offset: 0x0002A16A
		[global::Cpp2ILInjected.Token(Token = "0x6003E5D")]
		[global::Cpp2ILInjected.Address(RVA = "0x14B6444", Offset = "0x14B6444", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CaptureInterface), Member = "Scrolling", ReturnType = typeof(void))]
		public void Scrolling()
		{
			throw null;
		}

		// Token: 0x060037C2 RID: 14274 RVA: 0x0002BF6D File Offset: 0x0002A16D
		[global::Cpp2ILInjected.Token(Token = "0x6003E5E")]
		[global::Cpp2ILInjected.Address(RVA = "0x14B644C", Offset = "0x14B644C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CaptureInterface), Member = "Update", ReturnType = typeof(void))]
		public void Update()
		{
			throw null;
		}

		// Token: 0x060037C3 RID: 14275 RVA: 0x0002BF70 File Offset: 0x0002A170
		[global::Cpp2ILInjected.Token(Token = "0x6003E5F")]
		[global::Cpp2ILInjected.Address(RVA = "0x14B6454", Offset = "0x14B6454", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CaptureInterface), Member = "Draw", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		public void Draw(SpriteBatch sb)
		{
			throw null;
		}

		// Token: 0x060037C4 RID: 14276 RVA: 0x0002BF73 File Offset: 0x0002A173
		[global::Cpp2ILInjected.Token(Token = "0x6003E60")]
		[global::Cpp2ILInjected.Address(RVA = "0x14B1308", Offset = "0x14B1308", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public float GetProgress()
		{
			throw null;
		}

		// Token: 0x060037C5 RID: 14277 RVA: 0x0002BF76 File Offset: 0x0002A176
		[global::Cpp2ILInjected.Token(Token = "0x6003E61")]
		[global::Cpp2ILInjected.Address(RVA = "0x14B645C", Offset = "0x14B645C", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CaptureSettings), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Capture()
		{
			throw null;
		}

		// Token: 0x060037C6 RID: 14278 RVA: 0x0002BF79 File Offset: 0x0002A179
		[global::Cpp2ILInjected.Token(Token = "0x6003E62")]
		[global::Cpp2ILInjected.Address(RVA = "0x14B1304", Offset = "0x14B1304", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Capture(CaptureSettings settings)
		{
			throw null;
		}

		// Token: 0x060037C7 RID: 14279 RVA: 0x0002BF7C File Offset: 0x0002A17C
		[global::Cpp2ILInjected.Token(Token = "0x6003E63")]
		[global::Cpp2ILInjected.Address(RVA = "0x14B64DC", Offset = "0x14B64DC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void DrawTick()
		{
			throw null;
		}

		// Token: 0x060037C8 RID: 14280 RVA: 0x0002BF7F File Offset: 0x0002A17F
		[global::Cpp2ILInjected.Token(Token = "0x6003E64")]
		[global::Cpp2ILInjected.Address(RVA = "0x14B64E0", Offset = "0x14B64E0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x060037C9 RID: 14281 RVA: 0x0002BF82 File Offset: 0x0002A182
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6003E65")]
		[global::Cpp2ILInjected.Address(RVA = "0x14B64E4", Offset = "0x14B64E4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CaptureManager), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static CaptureManager()
		{
			throw null;
		}

		// Token: 0x040067FC RID: 26620
		[global::Cpp2ILInjected.Token(Token = "0x4007D17")]
		public static CaptureManager Instance;

		// Token: 0x040067FD RID: 26621
		[global::Cpp2ILInjected.Token(Token = "0x4007D18")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private CaptureInterface _interface;
	}
}
