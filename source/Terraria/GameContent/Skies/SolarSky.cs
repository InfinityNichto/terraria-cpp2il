using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Graphics.Effects;
using Terraria.Initializers;
using Terraria.Utilities;

namespace Terraria.GameContent.Skies
{
	// Token: 0x02000662 RID: 1634
	[global::Cpp2ILInjected.Token(Token = "0x20009DC")]
	public class SolarSky : CustomSky
	{
		// Token: 0x06003FE6 RID: 16358 RVA: 0x0002D68F File Offset: 0x0002B88F
		[global::Cpp2ILInjected.Token(Token = "0x6004A5C")]
		[global::Cpp2ILInjected.Address(RVA = "0x85A168", Offset = "0x85A168", Length = "0x264")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public override void OnLoad()
		{
			throw null;
		}

		// Token: 0x06003FE7 RID: 16359 RVA: 0x0002D692 File Offset: 0x0002B892
		[global::Cpp2ILInjected.Token(Token = "0x6004A5D")]
		[global::Cpp2ILInjected.Address(RVA = "0x85A3CC", Offset = "0x85A3CC", Length = "0x1C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalSeconds", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Update(GameTime gameTime)
		{
			throw null;
		}

		// Token: 0x06003FE8 RID: 16360 RVA: 0x0002D695 File Offset: 0x0002B895
		[global::Cpp2ILInjected.Token(Token = "0x6004A5E")]
		[global::Cpp2ILInjected.Address(RVA = "0x85A594", Offset = "0x85A594", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "ToVector4", ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector4), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Vector4),
			typeof(Vector4),
			typeof(float)
		}, ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[] { typeof(Vector4) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override Color OnTileColor(Color inColor)
		{
			throw null;
		}

		// Token: 0x06003FE9 RID: 16361 RVA: 0x0002D698 File Offset: 0x0002B898
		[global::Cpp2ILInjected.Token(Token = "0x6004A5F")]
		[global::Cpp2ILInjected.Address(RVA = "0x85A698", Offset = "0x85A698", Length = "0x98C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Rectangle),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(float),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Width", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Height", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Contains", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		public override void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth)
		{
			throw null;
		}

		// Token: 0x06003FEA RID: 16362 RVA: 0x0002D69B File Offset: 0x0002B89B
		[global::Cpp2ILInjected.Token(Token = "0x6004A60")]
		[global::Cpp2ILInjected.Address(RVA = "0x85B024", Offset = "0x85B024", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override float GetCloudAlpha()
		{
			throw null;
		}

		// Token: 0x06003FEB RID: 16363 RVA: 0x0002D69E File Offset: 0x0002B89E
		[global::Cpp2ILInjected.Token(Token = "0x6004A61")]
		[global::Cpp2ILInjected.Address(RVA = "0x85B04C", Offset = "0x85B04C", Length = "0x2F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloat", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<SolarSky.Meteor>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array[]), Member = "Sort", MemberTypeParameters = new object[] { typeof(SolarSky.Meteor) }, MemberParameters = new object[]
		{
			typeof(SolarSky.Meteor[]),
			typeof(Comparison<SolarSky.Meteor>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public override void Activate(Vector2 position, params object[] args)
		{
			throw null;
		}

		// Token: 0x06003FEC RID: 16364 RVA: 0x0002D6A1 File Offset: 0x0002B8A1
		[global::Cpp2ILInjected.Token(Token = "0x6004A62")]
		[global::Cpp2ILInjected.Address(RVA = "0x85B344", Offset = "0x85B344", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "CompareTo", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(int))]
		private int SortMethod(SolarSky.Meteor meteor1, SolarSky.Meteor meteor2)
		{
			throw null;
		}

		// Token: 0x06003FED RID: 16365 RVA: 0x0002D6A4 File Offset: 0x0002B8A4
		[global::Cpp2ILInjected.Token(Token = "0x6004A63")]
		[global::Cpp2ILInjected.Address(RVA = "0x85B354", Offset = "0x85B354", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Deactivate(params object[] args)
		{
			throw null;
		}

		// Token: 0x06003FEE RID: 16366 RVA: 0x0002D6A7 File Offset: 0x0002B8A7
		[global::Cpp2ILInjected.Token(Token = "0x6004A64")]
		[global::Cpp2ILInjected.Address(RVA = "0x85B35C", Offset = "0x85B35C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Reset()
		{
			throw null;
		}

		// Token: 0x06003FEF RID: 16367 RVA: 0x0002D6AA File Offset: 0x0002B8AA
		[global::Cpp2ILInjected.Token(Token = "0x6004A65")]
		[global::Cpp2ILInjected.Address(RVA = "0x85B364", Offset = "0x85B364", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool IsActive()
		{
			throw null;
		}

		// Token: 0x06003FF0 RID: 16368 RVA: 0x0002D6AD File Offset: 0x0002B8AD
		[global::Cpp2ILInjected.Token(Token = "0x6004A66")]
		[global::Cpp2ILInjected.Address(RVA = "0x85B38C", Offset = "0x85B38C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenEffectInitializer), Member = "LoadSkies", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomSky), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public SolarSky()
		{
			throw null;
		}

		// Token: 0x04006CFE RID: 27902
		[global::Cpp2ILInjected.Token(Token = "0x40084F6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private UnifiedRandom _random;

		// Token: 0x04006CFF RID: 27903
		[global::Cpp2ILInjected.Token(Token = "0x40084F7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private Asset<Texture2D> _planetTexture;

		// Token: 0x04006D00 RID: 27904
		[global::Cpp2ILInjected.Token(Token = "0x40084F8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private Asset<Texture2D> _bgTexture;

		// Token: 0x04006D01 RID: 27905
		[global::Cpp2ILInjected.Token(Token = "0x40084F9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private Asset<Texture2D> _meteorTexture;

		// Token: 0x04006D02 RID: 27906
		[global::Cpp2ILInjected.Token(Token = "0x40084FA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private bool _isActive;

		// Token: 0x04006D03 RID: 27907
		[global::Cpp2ILInjected.Token(Token = "0x40084FB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private SolarSky.Meteor[] _meteors;

		// Token: 0x04006D04 RID: 27908
		[global::Cpp2ILInjected.Token(Token = "0x40084FC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private float _fadeOpacity;

		// Token: 0x02000A59 RID: 2649
		[global::Cpp2ILInjected.Token(Token = "0x20009DD")]
		private struct Meteor
		{
			// Token: 0x04008E11 RID: 36369
			[global::Cpp2ILInjected.Token(Token = "0x40084FD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public Vector2 Position;

			// Token: 0x04008E12 RID: 36370
			[global::Cpp2ILInjected.Token(Token = "0x40084FE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public float Depth;

			// Token: 0x04008E13 RID: 36371
			[global::Cpp2ILInjected.Token(Token = "0x40084FF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
			public int FrameCounter;

			// Token: 0x04008E14 RID: 36372
			[global::Cpp2ILInjected.Token(Token = "0x4008500")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public float Scale;

			// Token: 0x04008E15 RID: 36373
			[global::Cpp2ILInjected.Token(Token = "0x4008501")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			public float StartX;
		}
	}
}
