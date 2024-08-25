using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.Drawing;

namespace Terraria.Graphics.Capture
{
	[global::Cpp2ILInjected.Token(Token = "0x200076D")]
	public class CaptureManager : IDisposable
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6003E5D")]
		[global::Cpp2ILInjected.Address(RVA = "0x14B6444", Offset = "0x14B6444", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CaptureInterface), Member = "Scrolling", ReturnType = typeof(void))]
		public void Scrolling()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003E5E")]
		[global::Cpp2ILInjected.Address(RVA = "0x14B644C", Offset = "0x14B644C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CaptureInterface), Member = "Update", ReturnType = typeof(void))]
		public void Update()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003E5F")]
		[global::Cpp2ILInjected.Address(RVA = "0x14B6454", Offset = "0x14B6454", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CaptureInterface), Member = "Draw", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		public void Draw(SpriteBatch sb)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003E60")]
		[global::Cpp2ILInjected.Address(RVA = "0x14B1308", Offset = "0x14B1308", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public float GetProgress()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6003E62")]
		[global::Cpp2ILInjected.Address(RVA = "0x14B1304", Offset = "0x14B1304", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Capture(CaptureSettings settings)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003E63")]
		[global::Cpp2ILInjected.Address(RVA = "0x14B64DC", Offset = "0x14B64DC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void DrawTick()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003E64")]
		[global::Cpp2ILInjected.Address(RVA = "0x14B64E0", Offset = "0x14B64E0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Dispose()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x4007D17")]
		public static CaptureManager Instance;

		[global::Cpp2ILInjected.Token(Token = "0x4007D18")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private CaptureInterface _interface;
	}
}
