using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.DataStructures;
using Terraria.Localization;

namespace Terraria.GameContent.Animations;

[Cpp2IlInjected.Token(Token = "0x2000650")]
public class Segments
{
	[Cpp2IlInjected.Token(Token = "0x2000A23")]
	public class LocalizedTextSegment : IAnimationSegment
	{
		[Cpp2IlInjected.Token(Token = "0x4008D77")]
		private const int PixelsForALine = 120;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008D78")]
		private LocalizedText _text;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008D79")]
		private float _timeToShowPeak;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4008D7A")]
		private Vector2 _anchorOffset;

		[Cpp2IlInjected.Token(Token = "0x170008DC")]
		public float DedicatedTimeNeeded
		{
			[Cpp2IlInjected.Token(Token = "0x600501A")]
			[Cpp2IlInjected.Address(RVA = "0xFB3978", Offset = "0xFB3978", VA = "0xFB3978", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600501B")]
		[Cpp2IlInjected.Address(RVA = "0xFB3984", Offset = "0xFB3984", VA = "0xFB3984")]
		public LocalizedTextSegment(float timeInAnimation, string textKey)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600501C")]
		[Cpp2IlInjected.Address(RVA = "0xFB39B8", Offset = "0xFB39B8", VA = "0xFB39B8")]
		public LocalizedTextSegment(float timeInAnimation, LocalizedText textObject, Vector2 anchorOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600501D")]
		[Cpp2IlInjected.Address(RVA = "0xFB39F0", Offset = "0xFB39F0", VA = "0xFB39F0", Slot = "5")]
		public void Draw(ref GameAnimationSegment info)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A24")]
	public abstract class AnimationSegmentWithActions<T> : IAnimationSegment
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008D7B")]
		private int _dedicatedTimeNeeded;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008D7C")]
		private int _lastDedicatedTimeNeeded;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008D7D")]
		protected int _targetTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008D7E")]
		private List<IAnimationSegmentAction<T>> _actions;

		[Cpp2IlInjected.Token(Token = "0x170008DD")]
		public float DedicatedTimeNeeded
		{
			[Cpp2IlInjected.Token(Token = "0x600501E")]
			[Cpp2IlInjected.Address(RVA = "0x163EFD8", Offset = "0x163EFD8", VA = "0x163EFD8", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600501F")]
		[Cpp2IlInjected.Address(RVA = "0x163EFE8", Offset = "0x163EFE8", VA = "0x163EFE8")]
		public AnimationSegmentWithActions(int targetTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005020")]
		[Cpp2IlInjected.Address(RVA = "0x163F060", Offset = "0x163F060", VA = "0x163F060")]
		protected void ProcessActions(T obj, float localTimeForObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005021")]
		[Cpp2IlInjected.Address(RVA = "0x163F178", Offset = "0x163F178", VA = "0x163F178")]
		public AnimationSegmentWithActions<T> Then(IAnimationSegmentAction<T> act)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6005022")]
		[Cpp2IlInjected.Address(RVA = "0x163F30C", Offset = "0x163F30C", VA = "0x163F30C")]
		public AnimationSegmentWithActions<T> With(IAnimationSegmentAction<T> act)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6005023")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void Bind(IAnimationSegmentAction<T> act);

		[Cpp2IlInjected.Token(Token = "0x6005024")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void Draw(ref GameAnimationSegment info);
	}

	[Cpp2IlInjected.Token(Token = "0x2000A25")]
	public class PlayerSegment : AnimationSegmentWithActions<Player>
	{
		[Cpp2IlInjected.Token(Token = "0x2000BC3")]
		public interface IShaderEffect
		{
			[Cpp2IlInjected.Token(Token = "0x60054E9")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void BeforeDrawing(ref GameAnimationSegment info);

			[Cpp2IlInjected.Token(Token = "0x60054EA")]
			[Cpp2IlInjected.Address(Slot = "1")]
			void AfterDrawing(ref GameAnimationSegment info);
		}

		[Cpp2IlInjected.Token(Token = "0x2000BC4")]
		public class ImmediateSpritebatchForPlayerDyesEffect : IShaderEffect
		{
			[Cpp2IlInjected.Token(Token = "0x60054EB")]
			[Cpp2IlInjected.Address(RVA = "0xFB501C", Offset = "0xFB501C", VA = "0xFB501C", Slot = "4")]
			public void BeforeDrawing(ref GameAnimationSegment info)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60054EC")]
			[Cpp2IlInjected.Address(RVA = "0xFB52B0", Offset = "0xFB52B0", VA = "0xFB52B0", Slot = "5")]
			public void AfterDrawing(ref GameAnimationSegment info)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60054ED")]
			[Cpp2IlInjected.Address(RVA = "0xFB5544", Offset = "0xFB5544", VA = "0xFB5544")]
			public ImmediateSpritebatchForPlayerDyesEffect()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4008D7F")]
		private Player _player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4008D80")]
		private Vector2 _anchorOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4008D81")]
		private Vector2 _normalizedOriginForHitbox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4008D82")]
		private IShaderEffect _shaderEffect;

		[Cpp2IlInjected.Token(Token = "0x4008D83")]
		private static Item _blankItem;

		[Cpp2IlInjected.Token(Token = "0x6005025")]
		[Cpp2IlInjected.Address(RVA = "0xFB47B4", Offset = "0xFB47B4", VA = "0xFB47B4")]
		public PlayerSegment(int targetTime, Vector2 anchorOffset, Vector2 normalizedHitboxOrigin)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005026")]
		[Cpp2IlInjected.Address(RVA = "0xFB4864", Offset = "0xFB4864", VA = "0xFB4864")]
		public PlayerSegment UseShaderEffect(IShaderEffect shaderEffect)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6005027")]
		[Cpp2IlInjected.Address(RVA = "0xFB486C", Offset = "0xFB486C", VA = "0xFB486C", Slot = "6")]
		protected override void Bind(IAnimationSegmentAction<Player> act)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005028")]
		[Cpp2IlInjected.Address(RVA = "0xFB4934", Offset = "0xFB4934", VA = "0xFB4934", Slot = "7")]
		public override void Draw(ref GameAnimationSegment info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005029")]
		[Cpp2IlInjected.Address(RVA = "0xFB4E98", Offset = "0xFB4E98", VA = "0xFB4E98")]
		private void ResetPlayerAnimation(ref GameAnimationSegment info)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A26")]
	public class NPCSegment : AnimationSegmentWithActions<NPC>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4008D84")]
		private NPC _npc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4008D85")]
		private Vector2 _anchorOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4008D86")]
		private Vector2 _normalizedOriginForHitbox;

		[Cpp2IlInjected.Token(Token = "0x600502B")]
		[Cpp2IlInjected.Address(RVA = "0xFB4000", Offset = "0xFB4000", VA = "0xFB4000")]
		public NPCSegment(int targetTime, int npcId, Vector2 anchorOffset, Vector2 normalizedNPCHitboxOrigin)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600502C")]
		[Cpp2IlInjected.Address(RVA = "0xFB419C", Offset = "0xFB419C", VA = "0xFB419C", Slot = "6")]
		protected override void Bind(IAnimationSegmentAction<NPC> act)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600502D")]
		[Cpp2IlInjected.Address(RVA = "0xFB4264", Offset = "0xFB4264", VA = "0xFB4264", Slot = "7")]
		public override void Draw(ref GameAnimationSegment info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600502E")]
		[Cpp2IlInjected.Address(RVA = "0xFB45F0", Offset = "0xFB45F0", VA = "0xFB45F0")]
		private void ResetNPCAnimation(ref GameAnimationSegment info)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A27")]
	public class LooseSprite
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008D87")]
		private DrawData _originalDrawData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4008D88")]
		private Asset<Texture2D> _asset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4008D89")]
		public DrawData CurrentDrawData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4008D8A")]
		public float CurrentOpacity;

		[Cpp2IlInjected.Token(Token = "0x600502F")]
		[Cpp2IlInjected.Address(RVA = "0xFB3EE0", Offset = "0xFB3EE0", VA = "0xFB3EE0")]
		public LooseSprite(DrawData data, Asset<Texture2D> asset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005030")]
		[Cpp2IlInjected.Address(RVA = "0xFB3F6C", Offset = "0xFB3F6C", VA = "0xFB3F6C")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A28")]
	public class SpriteSegment : AnimationSegmentWithActions<LooseSprite>
	{
		[Cpp2IlInjected.Token(Token = "0x2000BC5")]
		public interface IShaderEffect
		{
			[Cpp2IlInjected.Token(Token = "0x60054EE")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void BeforeDrawing(ref GameAnimationSegment info, ref DrawData drawData);

			[Cpp2IlInjected.Token(Token = "0x60054EF")]
			[Cpp2IlInjected.Address(Slot = "1")]
			void AfterDrawing(ref GameAnimationSegment info, ref DrawData drawData);
		}

		[Cpp2IlInjected.Token(Token = "0x2000BC6")]
		public class MaskedFadeEffect : IShaderEffect
		{
			[Cpp2IlInjected.Token(Token = "0x2000BD4")]
			public delegate Matrix GetMatrixAction();

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4009140")]
			private readonly string _shaderKey;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4009141")]
			private readonly int _verticalFrameCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4009142")]
			private readonly int _verticalFrameWait;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4009143")]
			private Panning _panX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4009144")]
			private Panning _panY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4009145")]
			private GetMatrixAction _fetchMatrix;

			[Cpp2IlInjected.Token(Token = "0x60054F0")]
			[Cpp2IlInjected.Address(RVA = "0xFB5A88", Offset = "0xFB5A88", VA = "0xFB5A88")]
			public MaskedFadeEffect([Optional] GetMatrixAction fetchMatrixMethod, string shaderKey = "MaskedFade", int verticalFrameCount = 1, int verticalFrameWait = 1)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60054F1")]
			[Cpp2IlInjected.Address(RVA = "0xFB5B58", Offset = "0xFB5B58", VA = "0xFB5B58")]
			private Matrix DefaultFetchMatrix()
			{
				return default(Matrix);
			}

			[Cpp2IlInjected.Token(Token = "0x60054F2")]
			[Cpp2IlInjected.Address(RVA = "0xFB5BC8", Offset = "0xFB5BC8", VA = "0xFB5BC8", Slot = "4")]
			public void BeforeDrawing(ref GameAnimationSegment info, ref DrawData drawData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60054F3")]
			[Cpp2IlInjected.Address(RVA = "0xFB6404", Offset = "0xFB6404", VA = "0xFB6404")]
			public MaskedFadeEffect WithPanX(Panning panning)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60054F4")]
			[Cpp2IlInjected.Address(RVA = "0xFB641C", Offset = "0xFB641C", VA = "0xFB641C")]
			public MaskedFadeEffect WithPanY(Panning panning)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60054F5")]
			[Cpp2IlInjected.Address(RVA = "0xFB6434", Offset = "0xFB6434", VA = "0xFB6434", Slot = "5")]
			public void AfterDrawing(ref GameAnimationSegment info, ref DrawData drawData)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4008D8B")]
		private LooseSprite _sprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4008D8C")]
		private Vector2 _anchorOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4008D8D")]
		private IShaderEffect _shaderEffect;

		[Cpp2IlInjected.Token(Token = "0x6005031")]
		[Cpp2IlInjected.Address(RVA = "0xFB554C", Offset = "0xFB554C", VA = "0xFB554C")]
		public SpriteSegment(Asset<Texture2D> asset, int targetTime, DrawData data, Vector2 anchorOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005032")]
		[Cpp2IlInjected.Address(RVA = "0xFB5668", Offset = "0xFB5668", VA = "0xFB5668", Slot = "6")]
		protected override void Bind(IAnimationSegmentAction<LooseSprite> act)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005033")]
		[Cpp2IlInjected.Address(RVA = "0xFB5730", Offset = "0xFB5730", VA = "0xFB5730")]
		public SpriteSegment UseShaderEffect(IShaderEffect shaderEffect)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6005034")]
		[Cpp2IlInjected.Address(RVA = "0xFB5738", Offset = "0xFB5738", VA = "0xFB5738", Slot = "7")]
		public override void Draw(ref GameAnimationSegment info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005035")]
		[Cpp2IlInjected.Address(RVA = "0xFB5A80", Offset = "0xFB5A80", VA = "0xFB5A80")]
		private void ResetSpriteAnimation(ref GameAnimationSegment info)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A29")]
	public struct Panning
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008D8E")]
		public float AmountOverTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4008D8F")]
		public float StartAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008D90")]
		public float Delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008D91")]
		public float Duration;

		[Cpp2IlInjected.Token(Token = "0x6005036")]
		[Cpp2IlInjected.Address(RVA = "0x39AAE8", Offset = "0x39AAE8", VA = "0x39AAE8")]
		public float GetPanAmount(float time)
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A2A")]
	public class EmoteSegment : IAnimationSegment
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008D93")]
		private int _targetTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4008D94")]
		private Vector2 _offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4008D95")]
		private SpriteEffects _effect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4008D96")]
		private int _emoteId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4008D97")]
		private Vector2 _velocity;

		[Cpp2IlInjected.Token(Token = "0x170008DE")]
		public float DedicatedTimeNeeded
		{
			[Cpp2IlInjected.Token(Token = "0x6005037")]
			[Cpp2IlInjected.Address(RVA = "0xFB326C", Offset = "0xFB326C", VA = "0xFB326C", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6005038")]
			[Cpp2IlInjected.Address(RVA = "0xFB3274", Offset = "0xFB3274", VA = "0xFB3274")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005039")]
		[Cpp2IlInjected.Address(RVA = "0xFB327C", Offset = "0xFB327C", VA = "0xFB327C")]
		public EmoteSegment(int emoteId, int targetTime, int timeToPlay, Vector2 position, SpriteEffects drawEffect, [Optional] Vector2 velocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600503A")]
		[Cpp2IlInjected.Address(RVA = "0xFB32C8", Offset = "0xFB32C8", VA = "0xFB32C8", Slot = "5")]
		public void Draw(ref GameAnimationSegment info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600503B")]
		[Cpp2IlInjected.Address(RVA = "0xFB3828", Offset = "0xFB3828", VA = "0xFB3828")]
		private Rectangle GetFrame(int wrappedTime)
		{
			return default(Rectangle);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4006C9B")]
	private const float PixelsToRollUpPerFrame = 0.5f;

	[Cpp2IlInjected.Token(Token = "0x6003F63")]
	[Cpp2IlInjected.Address(RVA = "0xFB3264", Offset = "0xFB3264", VA = "0xFB3264")]
	public Segments()
	{
	}
}
