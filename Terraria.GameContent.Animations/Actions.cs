using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.Animations;

[Cpp2IlInjected.Token(Token = "0x200064C")]
public class Actions
{
	[Cpp2IlInjected.Token(Token = "0x2000A20")]
	public class Players
	{
		[Cpp2IlInjected.Token(Token = "0x2000BA7")]
		public interface IPlayerAction : IAnimationSegmentAction<Player>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000BA8")]
		public class Fade : IPlayerAction, IAnimationSegmentAction<Player>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40090FC")]
			private int _duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40090FD")]
			private float _opacityTarget;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40090FE")]
			private float _delay;

			[Cpp2IlInjected.Token(Token = "0x1700092B")]
			public int ExpectedLengthOfActionInFrames
			{
				[Cpp2IlInjected.Token(Token = "0x600546C")]
				[Cpp2IlInjected.Address(RVA = "0xFB2438", Offset = "0xFB2438", VA = "0xFB2438", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6005469")]
			[Cpp2IlInjected.Address(RVA = "0xFB23E4", Offset = "0xFB23E4", VA = "0xFB23E4")]
			public Fade(float opacityTarget)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600546A")]
			[Cpp2IlInjected.Address(RVA = "0xFB240C", Offset = "0xFB240C", VA = "0xFB240C")]
			public Fade(float opacityTarget, int duration)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600546B")]
			[Cpp2IlInjected.Address(RVA = "0xFB2434", Offset = "0xFB2434", VA = "0xFB2434", Slot = "4")]
			public void BindTo(Player obj)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600546D")]
			[Cpp2IlInjected.Address(RVA = "0xFB2440", Offset = "0xFB2440", VA = "0xFB2440", Slot = "7")]
			public void SetDelay(float delay)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600546E")]
			[Cpp2IlInjected.Address(RVA = "0xFB2448", Offset = "0xFB2448", VA = "0xFB2448", Slot = "6")]
			public void ApplyTo(Player obj, float localTimeForObj)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000BA9")]
		public class Wait : IPlayerAction, IAnimationSegmentAction<Player>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40090FF")]
			private int _duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4009100")]
			private float _delay;

			[Cpp2IlInjected.Token(Token = "0x1700092C")]
			public int ExpectedLengthOfActionInFrames
			{
				[Cpp2IlInjected.Token(Token = "0x6005471")]
				[Cpp2IlInjected.Address(RVA = "0xFB27D4", Offset = "0xFB27D4", VA = "0xFB27D4", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600546F")]
			[Cpp2IlInjected.Address(RVA = "0xFB27B0", Offset = "0xFB27B0", VA = "0xFB27B0")]
			public Wait(int durationInFrames)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6005470")]
			[Cpp2IlInjected.Address(RVA = "0xFB27D0", Offset = "0xFB27D0", VA = "0xFB27D0", Slot = "4")]
			public void BindTo(Player obj)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6005472")]
			[Cpp2IlInjected.Address(RVA = "0xFB27DC", Offset = "0xFB27DC", VA = "0xFB27DC", Slot = "6")]
			public void ApplyTo(Player obj, float localTimeForObj)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6005473")]
			[Cpp2IlInjected.Address(RVA = "0xFB28D0", Offset = "0xFB28D0", VA = "0xFB28D0", Slot = "7")]
			public void SetDelay(float delay)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000BAA")]
		public class LookAt : IPlayerAction, IAnimationSegmentAction<Player>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4009101")]
			private int _direction;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4009102")]
			private float _delay;

			[Cpp2IlInjected.Token(Token = "0x1700092D")]
			public int ExpectedLengthOfActionInFrames
			{
				[Cpp2IlInjected.Token(Token = "0x6005476")]
				[Cpp2IlInjected.Address(RVA = "0xFB2578", Offset = "0xFB2578", VA = "0xFB2578", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6005474")]
			[Cpp2IlInjected.Address(RVA = "0xFB2554", Offset = "0xFB2554", VA = "0xFB2554")]
			public LookAt(int direction)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6005475")]
			[Cpp2IlInjected.Address(RVA = "0xFB2574", Offset = "0xFB2574", VA = "0xFB2574", Slot = "4")]
			public void BindTo(Player obj)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6005477")]
			[Cpp2IlInjected.Address(RVA = "0xFB2580", Offset = "0xFB2580", VA = "0xFB2580", Slot = "6")]
			public void ApplyTo(Player obj, float localTimeForObj)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6005478")]
			[Cpp2IlInjected.Address(RVA = "0xFB259C", Offset = "0xFB259C", VA = "0xFB259C", Slot = "7")]
			public void SetDelay(float delay)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000BAB")]
		public class MoveWithAcceleration : IPlayerAction, IAnimationSegmentAction<Player>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4009103")]
			private Vector2 _offsetPerFrame;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4009104")]
			private Vector2 _accelerationPerFrame;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4009105")]
			private int _duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4009106")]
			private float _delay;

			[Cpp2IlInjected.Token(Token = "0x1700092E")]
			public int ExpectedLengthOfActionInFrames
			{
				[Cpp2IlInjected.Token(Token = "0x600547B")]
				[Cpp2IlInjected.Address(RVA = "0xFB25E8", Offset = "0xFB25E8", VA = "0xFB25E8", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6005479")]
			[Cpp2IlInjected.Address(RVA = "0xFB25A4", Offset = "0xFB25A4", VA = "0xFB25A4")]
			public MoveWithAcceleration(Vector2 offsetPerFrame, Vector2 accelerationPerFrame, int durationInFrames)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600547A")]
			[Cpp2IlInjected.Address(RVA = "0xFB25E4", Offset = "0xFB25E4", VA = "0xFB25E4", Slot = "4")]
			public void BindTo(Player obj)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600547C")]
			[Cpp2IlInjected.Address(RVA = "0xFB25F0", Offset = "0xFB25F0", VA = "0xFB25F0", Slot = "7")]
			public void SetDelay(float delay)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600547D")]
			[Cpp2IlInjected.Address(RVA = "0xFB25F8", Offset = "0xFB25F8", VA = "0xFB25F8", Slot = "6")]
			public void ApplyTo(Player obj, float localTimeForObj)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005017")]
		[Cpp2IlInjected.Address(RVA = "0xFB23DC", Offset = "0xFB23DC", VA = "0xFB23DC")]
		public Players()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A21")]
	public class NPCs
	{
		[Cpp2IlInjected.Token(Token = "0x2000BAC")]
		public interface INPCAction : IAnimationSegmentAction<NPC>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000BAD")]
		public class Fade : INPCAction, IAnimationSegmentAction<NPC>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4009107")]
			private int _duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4009108")]
			private int _alphaPerFrame;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4009109")]
			private float _delay;

			[Cpp2IlInjected.Token(Token = "0x1700092F")]
			public int ExpectedLengthOfActionInFrames
			{
				[Cpp2IlInjected.Token(Token = "0x6005481")]
				[Cpp2IlInjected.Address(RVA = "0xFB16B8", Offset = "0xFB16B8", VA = "0xFB16B8", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600547E")]
			[Cpp2IlInjected.Address(RVA = "0xFB1664", Offset = "0xFB1664", VA = "0xFB1664")]
			public Fade(int alphaPerFrame)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600547F")]
			[Cpp2IlInjected.Address(RVA = "0xFB168C", Offset = "0xFB168C", VA = "0xFB168C")]
			public Fade(int alphaPerFrame, int duration)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6005480")]
			[Cpp2IlInjected.Address(RVA = "0xFB16B4", Offset = "0xFB16B4", VA = "0xFB16B4", Slot = "4")]
			public void BindTo(NPC obj)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6005482")]
			[Cpp2IlInjected.Address(RVA = "0xFB16C0", Offset = "0xFB16C0", VA = "0xFB16C0", Slot = "7")]
			public void SetDelay(float delay)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6005483")]
			[Cpp2IlInjected.Address(RVA = "0xFB16C8", Offset = "0xFB16C8", VA = "0xFB16C8", Slot = "6")]
			public void ApplyTo(NPC obj, float localTimeForObj)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000BAE")]
		public class ShowItem : INPCAction, IAnimationSegmentAction<NPC>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400910A")]
			private int _itemIdToShow;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400910B")]
			private int _duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400910C")]
			private float _delay;

			[Cpp2IlInjected.Token(Token = "0x17000930")]
			public int ExpectedLengthOfActionInFrames
			{
				[Cpp2IlInjected.Token(Token = "0x6005486")]
				[Cpp2IlInjected.Address(RVA = "0xFB1E2C", Offset = "0xFB1E2C", VA = "0xFB1E2C", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6005484")]
			[Cpp2IlInjected.Address(RVA = "0xFB1E00", Offset = "0xFB1E00", VA = "0xFB1E00")]
			public ShowItem(int durationInFrames, int itemIdToShow)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6005485")]
			[Cpp2IlInjected.Address(RVA = "0xFB1E28", Offset = "0xFB1E28", VA = "0xFB1E28", Slot = "4")]
			public void BindTo(NPC obj)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6005487")]
			[Cpp2IlInjected.Address(RVA = "0xFB1E34", Offset = "0xFB1E34", VA = "0xFB1E34", Slot = "7")]
			public void SetDelay(float delay)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6005488")]
			[Cpp2IlInjected.Address(RVA = "0xFB1E3C", Offset = "0xFB1E3C", VA = "0xFB1E3C", Slot = "6")]
			public void ApplyTo(NPC obj, float localTimeForObj)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6005489")]
			[Cpp2IlInjected.Address(RVA = "0xFB1FC0", Offset = "0xFB1FC0", VA = "0xFB1FC0")]
			private void FixNPCIfWasHoldingItem(NPC obj)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000BAF")]
		public class Move : INPCAction, IAnimationSegmentAction<NPC>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400910D")]
			private Vector2 _offsetPerFrame;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400910E")]
			private int _duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400910F")]
			private float _delay;

			[Cpp2IlInjected.Token(Token = "0x17000931")]
			public int ExpectedLengthOfActionInFrames
			{
				[Cpp2IlInjected.Token(Token = "0x600548C")]
				[Cpp2IlInjected.Address(RVA = "0xFB18B0", Offset = "0xFB18B0", VA = "0xFB18B0", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600548A")]
			[Cpp2IlInjected.Address(RVA = "0xFB187C", Offset = "0xFB187C", VA = "0xFB187C")]
			public Move(Vector2 offsetPerFrame, int durationInFrames)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600548B")]
			[Cpp2IlInjected.Address(RVA = "0xFB18AC", Offset = "0xFB18AC", VA = "0xFB18AC", Slot = "4")]
			public void BindTo(NPC obj)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600548D")]
			[Cpp2IlInjected.Address(RVA = "0xFB18B8", Offset = "0xFB18B8", VA = "0xFB18B8", Slot = "7")]
			public void SetDelay(float delay)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600548E")]
			[Cpp2IlInjected.Address(RVA = "0xFB18C0", Offset = "0xFB18C0", VA = "0xFB18C0", Slot = "6")]
			public void ApplyTo(NPC obj, float localTimeForObj)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000BB0")]
		public class MoveWithAcceleration : INPCAction, IAnimationSegmentAction<NPC>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4009110")]
			private Vector2 _offsetPerFrame;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4009111")]
			private Vector2 _accelerationPerFrame;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4009112")]
			private int _duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4009113")]
			private float _delay;

			[Cpp2IlInjected.Token(Token = "0x17000932")]
			public int ExpectedLengthOfActionInFrames
			{
				[Cpp2IlInjected.Token(Token = "0x6005491")]
				[Cpp2IlInjected.Address(RVA = "0xFB1A44", Offset = "0xFB1A44", VA = "0xFB1A44", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600548F")]
			[Cpp2IlInjected.Address(RVA = "0xFB1A00", Offset = "0xFB1A00", VA = "0xFB1A00")]
			public MoveWithAcceleration(Vector2 offsetPerFrame, Vector2 accelerationPerFrame, int durationInFrames)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6005490")]
			[Cpp2IlInjected.Address(RVA = "0xFB1A40", Offset = "0xFB1A40", VA = "0xFB1A40", Slot = "4")]
			public void BindTo(NPC obj)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6005492")]
			[Cpp2IlInjected.Address(RVA = "0xFB1A4C", Offset = "0xFB1A4C", VA = "0xFB1A4C", Slot = "7")]
			public void SetDelay(float delay)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6005493")]
			[Cpp2IlInjected.Address(RVA = "0xFB1A54", Offset = "0xFB1A54", VA = "0xFB1A54", Slot = "6")]
			public void ApplyTo(NPC obj, float localTimeForObj)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000BB1")]
		public class MoveWithRotor : INPCAction, IAnimationSegmentAction<NPC>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4009114")]
			private Vector2 _offsetPerFrame;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4009115")]
			private Vector2 _resultMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4009116")]
			private float _radialOffset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4009117")]
			private int _duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4009118")]
			private float _delay;

			[Cpp2IlInjected.Token(Token = "0x17000933")]
			public int ExpectedLengthOfActionInFrames
			{
				[Cpp2IlInjected.Token(Token = "0x6005496")]
				[Cpp2IlInjected.Address(RVA = "0xFB1C5C", Offset = "0xFB1C5C", VA = "0xFB1C5C", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6005494")]
			[Cpp2IlInjected.Address(RVA = "0xFB1C10", Offset = "0xFB1C10", VA = "0xFB1C10")]
			public MoveWithRotor(Vector2 radialOffset, float rotationPerFrame, Vector2 resultMultiplier, int durationInFrames)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6005495")]
			[Cpp2IlInjected.Address(RVA = "0xFB1C58", Offset = "0xFB1C58", VA = "0xFB1C58", Slot = "4")]
			public void BindTo(NPC obj)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6005497")]
			[Cpp2IlInjected.Address(RVA = "0xFB1C64", Offset = "0xFB1C64", VA = "0xFB1C64", Slot = "7")]
			public void SetDelay(float delay)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6005498")]
			[Cpp2IlInjected.Address(RVA = "0xFB1C6C", Offset = "0xFB1C6C", VA = "0xFB1C6C", Slot = "6")]
			public void ApplyTo(NPC obj, float localTimeForObj)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000BB2")]
		public class DoBunnyRestAnimation : INPCAction, IAnimationSegmentAction<NPC>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4009119")]
			private int _duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400911A")]
			private float _delay;

			[Cpp2IlInjected.Token(Token = "0x17000934")]
			public int ExpectedLengthOfActionInFrames
			{
				[Cpp2IlInjected.Token(Token = "0x600549B")]
				[Cpp2IlInjected.Address(RVA = "0xFB1598", Offset = "0xFB1598", VA = "0xFB1598", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6005499")]
			[Cpp2IlInjected.Address(RVA = "0xFB1574", Offset = "0xFB1574", VA = "0xFB1574")]
			public DoBunnyRestAnimation(int durationInFrames)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600549A")]
			[Cpp2IlInjected.Address(RVA = "0xFB1594", Offset = "0xFB1594", VA = "0xFB1594", Slot = "4")]
			public void BindTo(NPC obj)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600549C")]
			[Cpp2IlInjected.Address(RVA = "0xFB15A0", Offset = "0xFB15A0", VA = "0xFB15A0", Slot = "7")]
			public void SetDelay(float delay)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600549D")]
			[Cpp2IlInjected.Address(RVA = "0xFB15A8", Offset = "0xFB15A8", VA = "0xFB15A8", Slot = "6")]
			public void ApplyTo(NPC obj, float localTimeForObj)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000BB3")]
		public class Wait : INPCAction, IAnimationSegmentAction<NPC>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400911B")]
			private int _duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400911C")]
			private float _delay;

			[Cpp2IlInjected.Token(Token = "0x17000935")]
			public int ExpectedLengthOfActionInFrames
			{
				[Cpp2IlInjected.Token(Token = "0x60054A0")]
				[Cpp2IlInjected.Address(RVA = "0xFB205C", Offset = "0xFB205C", VA = "0xFB205C", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600549E")]
			[Cpp2IlInjected.Address(RVA = "0xFB2038", Offset = "0xFB2038", VA = "0xFB2038")]
			public Wait(int durationInFrames)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600549F")]
			[Cpp2IlInjected.Address(RVA = "0xFB2058", Offset = "0xFB2058", VA = "0xFB2058", Slot = "4")]
			public void BindTo(NPC obj)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60054A1")]
			[Cpp2IlInjected.Address(RVA = "0xFB2064", Offset = "0xFB2064", VA = "0xFB2064", Slot = "6")]
			public void ApplyTo(NPC obj, float localTimeForObj)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60054A2")]
			[Cpp2IlInjected.Address(RVA = "0xFB2158", Offset = "0xFB2158", VA = "0xFB2158", Slot = "7")]
			public void SetDelay(float delay)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000BB4")]
		public class Blink : INPCAction, IAnimationSegmentAction<NPC>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400911D")]
			private int _duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400911E")]
			private float _delay;

			[Cpp2IlInjected.Token(Token = "0x17000936")]
			public int ExpectedLengthOfActionInFrames
			{
				[Cpp2IlInjected.Token(Token = "0x60054A5")]
				[Cpp2IlInjected.Address(RVA = "0xFB143C", Offset = "0xFB143C", VA = "0xFB143C", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60054A3")]
			[Cpp2IlInjected.Address(RVA = "0xFB1418", Offset = "0xFB1418", VA = "0xFB1418")]
			public Blink(int durationInFrames)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60054A4")]
			[Cpp2IlInjected.Address(RVA = "0xFB1438", Offset = "0xFB1438", VA = "0xFB1438", Slot = "4")]
			public void BindTo(NPC obj)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60054A6")]
			[Cpp2IlInjected.Address(RVA = "0xFB1444", Offset = "0xFB1444", VA = "0xFB1444", Slot = "6")]
			public void ApplyTo(NPC obj, float localTimeForObj)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60054A7")]
			[Cpp2IlInjected.Address(RVA = "0xFB156C", Offset = "0xFB156C", VA = "0xFB156C", Slot = "7")]
			public void SetDelay(float delay)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000BB5")]
		public class LookAt : INPCAction, IAnimationSegmentAction<NPC>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400911F")]
			private int _direction;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4009120")]
			private float _delay;

			[Cpp2IlInjected.Token(Token = "0x17000937")]
			public int ExpectedLengthOfActionInFrames
			{
				[Cpp2IlInjected.Token(Token = "0x60054AA")]
				[Cpp2IlInjected.Address(RVA = "0xFB184C", Offset = "0xFB184C", VA = "0xFB184C", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60054A8")]
			[Cpp2IlInjected.Address(RVA = "0xFB1828", Offset = "0xFB1828", VA = "0xFB1828")]
			public LookAt(int direction)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60054A9")]
			[Cpp2IlInjected.Address(RVA = "0xFB1848", Offset = "0xFB1848", VA = "0xFB1848", Slot = "4")]
			public void BindTo(NPC obj)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60054AB")]
			[Cpp2IlInjected.Address(RVA = "0xFB1854", Offset = "0xFB1854", VA = "0xFB1854", Slot = "6")]
			public void ApplyTo(NPC obj, float localTimeForObj)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60054AC")]
			[Cpp2IlInjected.Address(RVA = "0xFB1874", Offset = "0xFB1874", VA = "0xFB1874", Slot = "7")]
			public void SetDelay(float delay)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000BB6")]
		public class PartyHard : INPCAction, IAnimationSegmentAction<NPC>
		{
			[Cpp2IlInjected.Token(Token = "0x17000938")]
			public int ExpectedLengthOfActionInFrames
			{
				[Cpp2IlInjected.Token(Token = "0x60054AF")]
				[Cpp2IlInjected.Address(RVA = "0xFB1DF0", Offset = "0xFB1DF0", VA = "0xFB1DF0", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60054AD")]
			[Cpp2IlInjected.Address(RVA = "0xFB1DD4", Offset = "0xFB1DD4", VA = "0xFB1DD4")]
			public PartyHard()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60054AE")]
			[Cpp2IlInjected.Address(RVA = "0xFB1DDC", Offset = "0xFB1DDC", VA = "0xFB1DDC", Slot = "4")]
			public void BindTo(NPC obj)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60054B0")]
			[Cpp2IlInjected.Address(RVA = "0xFB1DF8", Offset = "0xFB1DF8", VA = "0xFB1DF8", Slot = "6")]
			public void ApplyTo(NPC obj, float localTimeForObj)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60054B1")]
			[Cpp2IlInjected.Address(RVA = "0xFB1DFC", Offset = "0xFB1DFC", VA = "0xFB1DFC", Slot = "7")]
			public void SetDelay(float delay)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000BB7")]
		public class ForceAltTexture : INPCAction, IAnimationSegmentAction<NPC>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4009121")]
			private int _altTexture;

			[Cpp2IlInjected.Token(Token = "0x17000939")]
			public int ExpectedLengthOfActionInFrames
			{
				[Cpp2IlInjected.Token(Token = "0x60054B4")]
				[Cpp2IlInjected.Address(RVA = "0xFB1818", Offset = "0xFB1818", VA = "0xFB1818", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60054B2")]
			[Cpp2IlInjected.Address(RVA = "0xFB17EC", Offset = "0xFB17EC", VA = "0xFB17EC")]
			public ForceAltTexture(int altTexture)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60054B3")]
			[Cpp2IlInjected.Address(RVA = "0xFB180C", Offset = "0xFB180C", VA = "0xFB180C", Slot = "4")]
			public void BindTo(NPC obj)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60054B5")]
			[Cpp2IlInjected.Address(RVA = "0xFB1820", Offset = "0xFB1820", VA = "0xFB1820", Slot = "6")]
			public void ApplyTo(NPC obj, float localTimeForObj)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60054B6")]
			[Cpp2IlInjected.Address(RVA = "0xFB1824", Offset = "0xFB1824", VA = "0xFB1824", Slot = "7")]
			public void SetDelay(float delay)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000BB8")]
		public class Variant : INPCAction, IAnimationSegmentAction<NPC>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4009122")]
			private int _variant;

			[Cpp2IlInjected.Token(Token = "0x1700093A")]
			public int ExpectedLengthOfActionInFrames
			{
				[Cpp2IlInjected.Token(Token = "0x60054B9")]
				[Cpp2IlInjected.Address(RVA = "0xFB2028", Offset = "0xFB2028", VA = "0xFB2028", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60054B7")]
			[Cpp2IlInjected.Address(RVA = "0xFB1FFC", Offset = "0xFB1FFC", VA = "0xFB1FFC")]
			public Variant(int variant)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60054B8")]
			[Cpp2IlInjected.Address(RVA = "0xFB201C", Offset = "0xFB201C", VA = "0xFB201C", Slot = "4")]
			public void BindTo(NPC obj)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60054BA")]
			[Cpp2IlInjected.Address(RVA = "0xFB2030", Offset = "0xFB2030", VA = "0xFB2030", Slot = "6")]
			public void ApplyTo(NPC obj, float localTimeForObj)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60054BB")]
			[Cpp2IlInjected.Address(RVA = "0xFB2034", Offset = "0xFB2034", VA = "0xFB2034", Slot = "7")]
			public void SetDelay(float delay)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000BB9")]
		public class ZombieKnockOnDoor : INPCAction, IAnimationSegmentAction<NPC>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4009123")]
			private int _duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4009124")]
			private float _delay;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4009125")]
			private Vector2 bumpOffset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4009126")]
			private Vector2 bumpVelocity;

			[Cpp2IlInjected.Token(Token = "0x1700093B")]
			public int ExpectedLengthOfActionInFrames
			{
				[Cpp2IlInjected.Token(Token = "0x60054BE")]
				[Cpp2IlInjected.Address(RVA = "0xFB21EC", Offset = "0xFB21EC", VA = "0xFB21EC", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60054BC")]
			[Cpp2IlInjected.Address(RVA = "0xFB2160", Offset = "0xFB2160", VA = "0xFB2160")]
			public ZombieKnockOnDoor(int durationInFrames)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60054BD")]
			[Cpp2IlInjected.Address(RVA = "0xFB21E8", Offset = "0xFB21E8", VA = "0xFB21E8", Slot = "4")]
			public void BindTo(NPC obj)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60054BF")]
			[Cpp2IlInjected.Address(RVA = "0xFB21F4", Offset = "0xFB21F4", VA = "0xFB21F4", Slot = "7")]
			public void SetDelay(float delay)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60054C0")]
			[Cpp2IlInjected.Address(RVA = "0xFB21FC", Offset = "0xFB21FC", VA = "0xFB21FC", Slot = "6")]
			public void ApplyTo(NPC obj, float localTimeForObj)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005018")]
		[Cpp2IlInjected.Address(RVA = "0xFB1410", Offset = "0xFB1410", VA = "0xFB1410")]
		public NPCs()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A22")]
	public class Sprites
	{
		[Cpp2IlInjected.Token(Token = "0x2000BBA")]
		public interface ISpriteAction : IAnimationSegmentAction<Segments.LooseSprite>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000BBB")]
		public class Fade : ISpriteAction, IAnimationSegmentAction<Segments.LooseSprite>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4009127")]
			private int _duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4009128")]
			private float _opacityTarget;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4009129")]
			private float _delay;

			[Cpp2IlInjected.Token(Token = "0x1700093C")]
			public int ExpectedLengthOfActionInFrames
			{
				[Cpp2IlInjected.Token(Token = "0x60054C4")]
				[Cpp2IlInjected.Address(RVA = "0xFB2AD4", Offset = "0xFB2AD4", VA = "0xFB2AD4", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60054C1")]
			[Cpp2IlInjected.Address(RVA = "0xFB2A80", Offset = "0xFB2A80", VA = "0xFB2A80")]
			public Fade(float opacityTarget)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60054C2")]
			[Cpp2IlInjected.Address(RVA = "0xFB2AA8", Offset = "0xFB2AA8", VA = "0xFB2AA8")]
			public Fade(float opacityTarget, int duration)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60054C3")]
			[Cpp2IlInjected.Address(RVA = "0xFB2AD0", Offset = "0xFB2AD0", VA = "0xFB2AD0", Slot = "4")]
			public void BindTo(Segments.LooseSprite obj)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60054C5")]
			[Cpp2IlInjected.Address(RVA = "0xFB2ADC", Offset = "0xFB2ADC", VA = "0xFB2ADC", Slot = "7")]
			public void SetDelay(float delay)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60054C6")]
			[Cpp2IlInjected.Address(RVA = "0xFB2AE4", Offset = "0xFB2AE4", VA = "0xFB2AE4", Slot = "6")]
			public void ApplyTo(Segments.LooseSprite obj, float localTimeForObj)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000BBC")]
		public abstract class AScale : ISpriteAction, IAnimationSegmentAction<Segments.LooseSprite>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400912A")]
			protected int Duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400912B")]
			private Vector2 _scaleTarget;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400912C")]
			private float _delay;

			[Cpp2IlInjected.Token(Token = "0x1700093D")]
			public int ExpectedLengthOfActionInFrames
			{
				[Cpp2IlInjected.Token(Token = "0x60054CA")]
				[Cpp2IlInjected.Address(RVA = "0xFB2944", Offset = "0xFB2944", VA = "0xFB2944", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60054C7")]
			[Cpp2IlInjected.Address(RVA = "0xFB28E0", Offset = "0xFB28E0", VA = "0xFB28E0")]
			public AScale(Vector2 scaleTarget)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60054C8")]
			[Cpp2IlInjected.Address(RVA = "0xFB2910", Offset = "0xFB2910", VA = "0xFB2910")]
			public AScale(Vector2 scaleTarget, int duration)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60054C9")]
			[Cpp2IlInjected.Address(RVA = "0xFB2940", Offset = "0xFB2940", VA = "0xFB2940", Slot = "4")]
			public void BindTo(Segments.LooseSprite obj)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60054CB")]
			[Cpp2IlInjected.Address(RVA = "0xFB294C", Offset = "0xFB294C", VA = "0xFB294C", Slot = "7")]
			public void SetDelay(float delay)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60054CC")]
			[Cpp2IlInjected.Address(RVA = "0xFB2954", Offset = "0xFB2954", VA = "0xFB2954", Slot = "6")]
			public void ApplyTo(Segments.LooseSprite obj, float localTimeForObj)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60054CD")]
			[Cpp2IlInjected.Address(Slot = "8")]
			protected abstract float GetProgress(float durationInFramesToApply);
		}

		[Cpp2IlInjected.Token(Token = "0x2000BBD")]
		public class LinearScale : AScale
		{
			[Cpp2IlInjected.Token(Token = "0x60054CE")]
			[Cpp2IlInjected.Address(RVA = "0xFB2BE4", Offset = "0xFB2BE4", VA = "0xFB2BE4")]
			public LinearScale(Vector2 scaleTarget)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60054CF")]
			[Cpp2IlInjected.Address(RVA = "0xFB2C14", Offset = "0xFB2C14", VA = "0xFB2C14")]
			public LinearScale(Vector2 scaleTarget, int duration)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60054D0")]
			[Cpp2IlInjected.Address(RVA = "0xFB2C44", Offset = "0xFB2C44", VA = "0xFB2C44", Slot = "8")]
			protected override float GetProgress(float durationInFramesToApply)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000BBE")]
		public class OutCircleScale : AScale
		{
			[Cpp2IlInjected.Token(Token = "0x60054D1")]
			[Cpp2IlInjected.Address(RVA = "0xFB2CE8", Offset = "0xFB2CE8", VA = "0xFB2CE8")]
			public OutCircleScale(Vector2 scaleTarget)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60054D2")]
			[Cpp2IlInjected.Address(RVA = "0xFB2D18", Offset = "0xFB2D18", VA = "0xFB2D18")]
			public OutCircleScale(Vector2 scaleTarget, int duration)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60054D3")]
			[Cpp2IlInjected.Address(RVA = "0xFB2D48", Offset = "0xFB2D48", VA = "0xFB2D48", Slot = "8")]
			protected override float GetProgress(float durationInFramesToApply)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000BBF")]
		public class Wait : ISpriteAction, IAnimationSegmentAction<Segments.LooseSprite>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400912D")]
			private int _duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400912E")]
			private float _delay;

			[Cpp2IlInjected.Token(Token = "0x1700093E")]
			public int ExpectedLengthOfActionInFrames
			{
				[Cpp2IlInjected.Token(Token = "0x60054D6")]
				[Cpp2IlInjected.Address(RVA = "0xFB3250", Offset = "0xFB3250", VA = "0xFB3250", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60054D4")]
			[Cpp2IlInjected.Address(RVA = "0xFB322C", Offset = "0xFB322C", VA = "0xFB322C")]
			public Wait(int durationInFrames)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60054D5")]
			[Cpp2IlInjected.Address(RVA = "0xFB324C", Offset = "0xFB324C", VA = "0xFB324C", Slot = "4")]
			public void BindTo(Segments.LooseSprite obj)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60054D7")]
			[Cpp2IlInjected.Address(RVA = "0xFB3258", Offset = "0xFB3258", VA = "0xFB3258", Slot = "6")]
			public void ApplyTo(Segments.LooseSprite obj, float localTimeForObj)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60054D8")]
			[Cpp2IlInjected.Address(RVA = "0xFB325C", Offset = "0xFB325C", VA = "0xFB325C", Slot = "7")]
			public void SetDelay(float delay)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000BC0")]
		public class SimulateGravity : ISpriteAction, IAnimationSegmentAction<Segments.LooseSprite>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400912F")]
			private int _duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4009130")]
			private float _delay;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4009131")]
			private Vector2 _initialVelocity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4009132")]
			private Vector2 _gravityPerFrame;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4009133")]
			private float _rotationPerFrame;

			[Cpp2IlInjected.Token(Token = "0x1700093F")]
			public int ExpectedLengthOfActionInFrames
			{
				[Cpp2IlInjected.Token(Token = "0x60054DB")]
				[Cpp2IlInjected.Address(RVA = "0xFB30D8", Offset = "0xFB30D8", VA = "0xFB30D8", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60054D9")]
			[Cpp2IlInjected.Address(RVA = "0xFB308C", Offset = "0xFB308C", VA = "0xFB308C")]
			public SimulateGravity(Vector2 initialVelocity, Vector2 gravityPerFrame, float rotationPerFrame, int duration)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60054DA")]
			[Cpp2IlInjected.Address(RVA = "0xFB30D4", Offset = "0xFB30D4", VA = "0xFB30D4", Slot = "4")]
			public void BindTo(Segments.LooseSprite obj)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60054DC")]
			[Cpp2IlInjected.Address(RVA = "0xFB30E0", Offset = "0xFB30E0", VA = "0xFB30E0", Slot = "7")]
			public void SetDelay(float delay)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60054DD")]
			[Cpp2IlInjected.Address(RVA = "0xFB30E8", Offset = "0xFB30E8", VA = "0xFB30E8", Slot = "6")]
			public void ApplyTo(Segments.LooseSprite obj, float localTimeForObj)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000BC1")]
		public class SetFrame : ISpriteAction, IAnimationSegmentAction<Segments.LooseSprite>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4009134")]
			private int _targetFrameX;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4009135")]
			private int _targetFrameY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4009136")]
			private int _paddingX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4009137")]
			private int _paddingY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4009138")]
			private float _delay;

			[Cpp2IlInjected.Token(Token = "0x17000940")]
			public int ExpectedLengthOfActionInFrames
			{
				[Cpp2IlInjected.Token(Token = "0x60054E0")]
				[Cpp2IlInjected.Address(RVA = "0xFB2E98", Offset = "0xFB2E98", VA = "0xFB2E98", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60054DE")]
			[Cpp2IlInjected.Address(RVA = "0xFB2E5C", Offset = "0xFB2E5C", VA = "0xFB2E5C")]
			public SetFrame(int frameX, int frameY, int paddingX = 2, int paddingY = 2)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60054DF")]
			[Cpp2IlInjected.Address(RVA = "0xFB2E94", Offset = "0xFB2E94", VA = "0xFB2E94", Slot = "4")]
			public void BindTo(Segments.LooseSprite obj)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60054E1")]
			[Cpp2IlInjected.Address(RVA = "0xFB2EA0", Offset = "0xFB2EA0", VA = "0xFB2EA0", Slot = "7")]
			public void SetDelay(float delay)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60054E2")]
			[Cpp2IlInjected.Address(RVA = "0xFB2EA8", Offset = "0xFB2EA8", VA = "0xFB2EA8", Slot = "6")]
			public void ApplyTo(Segments.LooseSprite obj, float localTimeForObj)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000BC2")]
		public class SetFrameSequence : ISpriteAction, IAnimationSegmentAction<Segments.LooseSprite>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4009139")]
			private Point[] _frameIndices;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400913A")]
			private int _timePerFrame;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400913B")]
			private int _paddingX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400913C")]
			private int _paddingY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400913D")]
			private float _delay;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400913E")]
			private int _duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400913F")]
			private bool _loop;

			[Cpp2IlInjected.Token(Token = "0x17000941")]
			public int ExpectedLengthOfActionInFrames
			{
				[Cpp2IlInjected.Token(Token = "0x60054E6")]
				[Cpp2IlInjected.Address(RVA = "0xFB2F8C", Offset = "0xFB2F8C", VA = "0xFB2F8C", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60054E3")]
			[Cpp2IlInjected.Address(RVA = "0xFB2EFC", Offset = "0xFB2EFC", VA = "0xFB2EFC")]
			public SetFrameSequence(int duration, Point[] frameIndices, int timePerFrame, int paddingX = 2, int paddingY = 2)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60054E4")]
			[Cpp2IlInjected.Address(RVA = "0xFB2F44", Offset = "0xFB2F44", VA = "0xFB2F44")]
			public SetFrameSequence(Point[] frameIndices, int timePerFrame, int paddingX = 2, int paddingY = 2)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60054E5")]
			[Cpp2IlInjected.Address(RVA = "0xFB2F88", Offset = "0xFB2F88", VA = "0xFB2F88", Slot = "4")]
			public void BindTo(Segments.LooseSprite obj)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60054E7")]
			[Cpp2IlInjected.Address(RVA = "0xFB2F94", Offset = "0xFB2F94", VA = "0xFB2F94", Slot = "7")]
			public void SetDelay(float delay)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60054E8")]
			[Cpp2IlInjected.Address(RVA = "0xFB2F9C", Offset = "0xFB2F9C", VA = "0xFB2F9C", Slot = "6")]
			public void ApplyTo(Segments.LooseSprite obj, float localTimeForObj)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005019")]
		[Cpp2IlInjected.Address(RVA = "0xFB28D8", Offset = "0xFB28D8", VA = "0xFB28D8")]
		public Sprites()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003F60")]
	[Cpp2IlInjected.Address(RVA = "0xFB1408", Offset = "0xFB1408", VA = "0xFB1408")]
	public Actions()
	{
	}
}
