using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics.Effects
{
	// Token: 0x02000523 RID: 1315
	[global::Cpp2ILInjected.Token(Token = "0x200078C")]
	public class SkyManager : EffectManager<CustomSky>
	{
		// Token: 0x0600387E RID: 14462 RVA: 0x0002C162 File Offset: 0x0002A362
		[global::Cpp2ILInjected.Token(Token = "0x6003F1D")]
		[global::Cpp2ILInjected.Address(RVA = "0x742A94", Offset = "0x742A94", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Values", ReturnType = "ValueCollection<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.ValueCollection), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.ValueCollection.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.ValueCollection.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<object>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public void Reset()
		{
			throw null;
		}

		// Token: 0x0600387F RID: 14463 RVA: 0x0002C165 File Offset: 0x0002A365
		[global::Cpp2ILInjected.Token(Token = "0x6003F1E")]
		[global::Cpp2ILInjected.Address(RVA = "0x742C14", Offset = "0x742C14", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdate", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedListNode<object>), Member = "get_Next", ReturnType = "System.Collections.Generic.LinkedListNode`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<object>), Member = "Remove", MemberParameters = new object[] { typeof(LinkedListNode<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void Update(GameTime gameTime)
		{
			throw null;
		}

		// Token: 0x06003880 RID: 14464 RVA: 0x0002C168 File Offset: 0x0002A368
		[global::Cpp2ILInjected.Token(Token = "0x6003F1F")]
		[global::Cpp2ILInjected.Address(RVA = "0x742D48", Offset = "0x742D48", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Draw(SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x06003881 RID: 14465 RVA: 0x0002C16B File Offset: 0x0002A36B
		[global::Cpp2ILInjected.Token(Token = "0x6003F20")]
		[global::Cpp2ILInjected.Address(RVA = "0x742FD4", Offset = "0x742FD4", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawUnderworldBackgroudLayer", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(Vector2),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawSurfaceBG", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawSurfaceBG_BackMountainsStep1", MemberParameters = new object[]
		{
			typeof(double),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawSurfaceBG_BackMountainsStep2", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawSurfaceBG_Mushroom", MemberParameters = new object[]
		{
			typeof(double),
			typeof(float),
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawSurfaceBG_Crimson", MemberParameters = new object[]
		{
			typeof(double),
			typeof(float),
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawSurfaceBG_Snow", MemberParameters = new object[]
		{
			typeof(double),
			typeof(float),
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawSurfaceBG_Hallow", MemberParameters = new object[]
		{
			typeof(double),
			typeof(float),
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawSurfaceBG_GoodEvilDesert", MemberParameters = new object[]
		{
			typeof(double),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawSurfaceBG_Jungle", MemberParameters = new object[]
		{
			typeof(double),
			typeof(float),
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawSurfaceBG_Desert", MemberParameters = new object[]
		{
			typeof(double),
			typeof(float),
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawSurfaceBG_Corrupt", MemberParameters = new object[]
		{
			typeof(double),
			typeof(float),
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawSurfaceBG_Forest", MemberParameters = new object[]
		{
			typeof(double),
			typeof(float),
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 34)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SkyManager), Member = "DrawDepthRange", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		public void DrawToDepth(SpriteBatch spriteBatch, float minDepth)
		{
			throw null;
		}

		// Token: 0x06003882 RID: 14466 RVA: 0x0002C16E File Offset: 0x0002A36E
		[global::Cpp2ILInjected.Token(Token = "0x6003F21")]
		[global::Cpp2ILInjected.Address(RVA = "0x742D5C", Offset = "0x742D5C", Length = "0x278")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SkyManager), Member = "DrawToDepth", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SkyManager), Member = "DrawRemainingDepth", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "End", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Begin", MemberParameters = new object[]
		{
			typeof(SpriteSortMode),
			typeof(BlendState),
			typeof(SamplerState),
			typeof(DepthStencilState),
			typeof(RasterizerState),
			typeof(Effect),
			typeof(Matrix?),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public void DrawDepthRange(SpriteBatch spriteBatch, float minDepth, float maxDepth)
		{
			throw null;
		}

		// Token: 0x06003883 RID: 14467 RVA: 0x0002C171 File Offset: 0x0002A371
		[global::Cpp2ILInjected.Token(Token = "0x6003F22")]
		[global::Cpp2ILInjected.Address(RVA = "0x743004", Offset = "0x743004", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawUnderworldBackground", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawSurfaceBG", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SkyManager), Member = "DrawDepthRange", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		public void DrawRemainingDepth(SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x06003884 RID: 14468 RVA: 0x0002C174 File Offset: 0x0002A374
		[global::Cpp2ILInjected.Token(Token = "0x6003F23")]
		[global::Cpp2ILInjected.Address(RVA = "0x743030", Offset = "0x743030", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawUnderworldBackground", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawSurfaceBG", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public void ResetDepthTracker()
		{
			throw null;
		}

		// Token: 0x06003885 RID: 14469 RVA: 0x0002C177 File Offset: 0x0002A377
		[global::Cpp2ILInjected.Token(Token = "0x6003F24")]
		[global::Cpp2ILInjected.Address(RVA = "0x74303C", Offset = "0x74303C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetStartingDepth(float depth)
		{
			throw null;
		}

		// Token: 0x06003886 RID: 14470 RVA: 0x0002C17A File Offset: 0x0002A37A
		[global::Cpp2ILInjected.Token(Token = "0x6003F25")]
		[global::Cpp2ILInjected.Address(RVA = "0x743044", Offset = "0x743044", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<object>), Member = "AddLast", MemberParameters = new object[] { typeof(object) }, ReturnType = "System.Collections.Generic.LinkedListNode`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void OnActivate(CustomSky effect, Vector2 position)
		{
			throw null;
		}

		// Token: 0x06003887 RID: 14471 RVA: 0x0002C17D File Offset: 0x0002A37D
		[global::Cpp2ILInjected.Token(Token = "0x6003F26")]
		[global::Cpp2ILInjected.Address(RVA = "0x7430C0", Offset = "0x7430C0", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "ApplyColorOfTheSkiesToTiles", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public Color ProcessTileColor(Color color)
		{
			throw null;
		}

		// Token: 0x06003888 RID: 14472 RVA: 0x0002C180 File Offset: 0x0002A380
		[global::Cpp2ILInjected.Token(Token = "0x6003F27")]
		[global::Cpp2ILInjected.Address(RVA = "0x743218", Offset = "0x743218", Length = "0x168")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawSurfaceBG", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public float ProcessCloudAlpha()
		{
			throw null;
		}

		// Token: 0x06003889 RID: 14473 RVA: 0x0002C183 File Offset: 0x0002A383
		[global::Cpp2ILInjected.Token(Token = "0x6003F28")]
		[global::Cpp2ILInjected.Address(RVA = "0x743380", Offset = "0x743380", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUser), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(PlatformUser)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SkyManager), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LinkedList<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectManager<>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public SkyManager()
		{
			throw null;
		}

		// Token: 0x0600388A RID: 14474 RVA: 0x0002C186 File Offset: 0x0002A386
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6003F29")]
		[global::Cpp2ILInjected.Address(RVA = "0x743410", Offset = "0x743410", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SkyManager), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static SkyManager()
		{
			throw null;
		}

		// Token: 0x04006879 RID: 26745
		[global::Cpp2ILInjected.Token(Token = "0x4007D9F")]
		public static SkyManager Instance;

		// Token: 0x0400687A RID: 26746
		[global::Cpp2ILInjected.Token(Token = "0x4007DA0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private float _lastDepth;

		// Token: 0x0400687B RID: 26747
		[global::Cpp2ILInjected.Token(Token = "0x4007DA1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private LinkedList<CustomSky> _activeSkies;
	}
}
