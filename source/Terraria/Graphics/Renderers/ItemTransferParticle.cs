using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.Drawing;
using Terraria.UI;
using Terraria.Utilities;

namespace Terraria.Graphics.Renderers
{
	[global::Cpp2ILInjected.Token(Token = "0x2000754")]
	public class ItemTransferParticle : IPooledParticle, IParticle
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000787")]
		public bool ShouldBeRemovedFromRenderer
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003DC5")]
			[global::Cpp2ILInjected.Address(RVA = "0x14A55C4", Offset = "0x14A55C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003DC6")]
			[global::Cpp2ILInjected.Address(RVA = "0x14A55CC", Offset = "0x14A55CC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003DC7")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A55D8", Offset = "0x14A55D8", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "GetNewItemTransferParticle", ReturnType = typeof(ItemTransferParticle))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ItemTransferParticle()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003DC8")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A563C", Offset = "0x14A563C", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Update(ref ParticleRendererSettings settings)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003DC9")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A565C", Offset = "0x14A565C", Length = "0x300")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "Spawn_ItemTransfer", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "SafeNormalize", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "RotatedBy", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(double),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Distance", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextVector2Circular", MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_UnaryNegation", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public void Prepare(int itemType, int lifeTimeTotal, Vector2 playerPosition, Vector2 chestPosition)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003DCA")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A595C", Offset = "0x14A595C", Length = "0x2CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Remap", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Hermite", MemberParameters = new object[]
		{
			typeof(ref Vector2),
			typeof(ref Vector2),
			typeof(ref Vector2),
			typeof(ref Vector2),
			typeof(float),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "DrawItemIcon", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(int),
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(float),
			typeof(float),
			typeof(Color)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public void Draw(ref ParticleRendererSettings settings, SpriteBatch spritebatch)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000788")]
		public bool IsRestingInPool
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003DCB")]
			[global::Cpp2ILInjected.Address(RVA = "0x14A5C28", Offset = "0x14A5C28", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003DCC")]
			[global::Cpp2ILInjected.Address(RVA = "0x14A5C30", Offset = "0x14A5C30", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003DCD")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A5C3C", Offset = "0x14A5C3C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void RestInPool()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003DCE")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A5C48", Offset = "0x14A5C48", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual void FetchFromPool()
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007C77")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool <ShouldBeRemovedFromRenderer>k__BackingField;

		[global::Cpp2ILInjected.Token(Token = "0x4007C78")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public Vector2 StartPosition;

		[global::Cpp2ILInjected.Token(Token = "0x4007C79")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public Vector2 EndPosition;

		[global::Cpp2ILInjected.Token(Token = "0x4007C7A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public Vector2 BezierHelper1;

		[global::Cpp2ILInjected.Token(Token = "0x4007C7B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		public Vector2 BezierHelper2;

		[global::Cpp2ILInjected.Token(Token = "0x4007C7C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private Item _itemInstance;

		[global::Cpp2ILInjected.Token(Token = "0x4007C7D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private int _lifeTimeCounted;

		[global::Cpp2ILInjected.Token(Token = "0x4007C7E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		private int _lifeTimeTotal;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007C7F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private bool <IsRestingInPool>k__BackingField;
	}
}
