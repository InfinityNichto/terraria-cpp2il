using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using ReLogic.Utilities;
using Terraria.DataStructures;
using Terraria.GameContent.Ambience;
using Terraria.Graphics;
using Terraria.Graphics.Effects;
using Terraria.Utilities;

namespace Terraria.GameContent.Skies;

[Cpp2IlInjected.Token(Token = "0x200065C")]
public class AmbientSky : CustomSky
{
	[Cpp2IlInjected.Token(Token = "0x2000A31")]
	private abstract class SkyEntity
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008DA4")]
		public Vector2 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4008DA5")]
		public Asset<Texture2D> Texture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4008DA6")]
		public SpriteFrame Frame;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4008DA7")]
		public float Depth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4008DA8")]
		public SpriteEffects Effects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4008DA9")]
		public bool IsActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4008DAA")]
		public float Rotation;

		[Cpp2IlInjected.Token(Token = "0x170008E1")]
		public Rectangle SourceRectangle
		{
			[Cpp2IlInjected.Token(Token = "0x6005055")]
			[Cpp2IlInjected.Address(RVA = "0x111C4E0", Offset = "0x111C4E0", VA = "0x111C4E0")]
			get
			{
				return default(Rectangle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005056")]
		[Cpp2IlInjected.Address(RVA = "0x1118064", Offset = "0x1118064", VA = "0x1118064")]
		protected void NextFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005057")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract Color GetColor(Color backgroundColor);

		[Cpp2IlInjected.Token(Token = "0x6005058")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void Update(int frameCount);

		[Cpp2IlInjected.Token(Token = "0x6005059")]
		[Cpp2IlInjected.Address(RVA = "0x1117858", Offset = "0x1117858", VA = "0x1117858")]
		protected void SetPositionInWorldBasedOnScreenSpace(Vector2 actualWorldSpace)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600505A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract Vector2 GetDrawPosition();

		[Cpp2IlInjected.Token(Token = "0x600505B")]
		[Cpp2IlInjected.Address(RVA = "0x111C540", Offset = "0x111C540", VA = "0x111C540", Slot = "7")]
		public virtual void Draw(SpriteBatch spriteBatch, float depthScale, float minDepth, float maxDepth)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600505C")]
		[Cpp2IlInjected.Address(RVA = "0x111A59C", Offset = "0x111A59C", VA = "0x111A59C")]
		public void CommonDraw(SpriteBatch spriteBatch, float depthScale, float minDepth, float maxDepth)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600505D")]
		[Cpp2IlInjected.Address(RVA = "0x111C560", Offset = "0x111C560", VA = "0x111C560")]
		internal Vector2 GetDrawPositionByDepth()
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600505E")]
		[Cpp2IlInjected.Address(RVA = "0x1119AC0", Offset = "0x1119AC0", VA = "0x1119AC0")]
		internal float Helper_GetOpacityWithAccountingForOceanWaterLine()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600505F")]
		[Cpp2IlInjected.Address(RVA = "0x1119964", Offset = "0x1119964", VA = "0x1119964")]
		protected SkyEntity()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A32")]
	private class FadingSkyEntity : SkyEntity
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4008DAB")]
		protected int LifeTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4008DAC")]
		protected Vector2 Velocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4008DAD")]
		protected int FramingSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4008DAE")]
		protected int TimeEntitySpawnedIn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4008DAF")]
		protected float Opacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4008DB0")]
		protected float BrightnessLerper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4008DB1")]
		protected float FinalOpacityMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4008DB2")]
		protected float OpacityNormalizedTimeToFadeIn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4008DB3")]
		protected float OpacityNormalizedTimeToFadeOut;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4008DB4")]
		protected int FrameOffset;

		[Cpp2IlInjected.Token(Token = "0x6005060")]
		[Cpp2IlInjected.Address(RVA = "0x11172C8", Offset = "0x11172C8", VA = "0x11172C8")]
		public FadingSkyEntity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005061")]
		[Cpp2IlInjected.Address(RVA = "0x11176F4", Offset = "0x11176F4", VA = "0x11176F4", Slot = "5")]
		public override void Update(int frameCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005062")]
		[Cpp2IlInjected.Address(RVA = "0x1119ABC", Offset = "0x1119ABC", VA = "0x1119ABC", Slot = "8")]
		public virtual void UpdateVelocity(int frameCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005063")]
		[Cpp2IlInjected.Address(RVA = "0x11199A8", Offset = "0x11199A8", VA = "0x11199A8")]
		private void UpdateOpacity(int frameCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005064")]
		[Cpp2IlInjected.Address(RVA = "0x1119974", Offset = "0x1119974", VA = "0x1119974")]
		private bool IsMovementDone(int frameCount)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6005065")]
		[Cpp2IlInjected.Address(RVA = "0x11185E0", Offset = "0x11185E0", VA = "0x11185E0", Slot = "4")]
		public override Color GetColor(Color backgroundColor)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6005066")]
		[Cpp2IlInjected.Address(RVA = "0x111782C", Offset = "0x111782C", VA = "0x111782C")]
		public void StartFadingOut(int currentFrameCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005067")]
		[Cpp2IlInjected.Address(RVA = "0x1119C8C", Offset = "0x1119C8C", VA = "0x1119C8C", Slot = "6")]
		public override Vector2 GetDrawPosition()
		{
			return default(Vector2);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A33")]
	private class ButterfliesSkyEntity : FadingSkyEntity
	{
		[Cpp2IlInjected.Token(Token = "0x6005068")]
		[Cpp2IlInjected.Address(RVA = "0x11145D0", Offset = "0x11145D0", VA = "0x11145D0")]
		public ButterfliesSkyEntity(Player player, FastRandom random)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005069")]
		[Cpp2IlInjected.Address(RVA = "0x111894C", Offset = "0x111894C", VA = "0x111894C", Slot = "8")]
		public override void UpdateVelocity(int frameCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600506A")]
		[Cpp2IlInjected.Address(RVA = "0x1118ABC", Offset = "0x1118ABC", VA = "0x1118ABC", Slot = "5")]
		public override void Update(int frameCount)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A34")]
	private class LostKiteSkyEntity : FadingSkyEntity
	{
		[Cpp2IlInjected.Token(Token = "0x600506B")]
		[Cpp2IlInjected.Address(RVA = "0x11149A8", Offset = "0x11149A8", VA = "0x11149A8")]
		public LostKiteSkyEntity(Player player, FastRandom random)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600506C")]
		[Cpp2IlInjected.Address(RVA = "0x111B10C", Offset = "0x111B10C", VA = "0x111B10C", Slot = "8")]
		public override void UpdateVelocity(int frameCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600506D")]
		[Cpp2IlInjected.Address(RVA = "0x111B2E8", Offset = "0x111B2E8", VA = "0x111B2E8", Slot = "5")]
		public override void Update(int frameCount)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A35")]
	private class PegasusSkyEntity : FadingSkyEntity
	{
		[Cpp2IlInjected.Token(Token = "0x600506E")]
		[Cpp2IlInjected.Address(RVA = "0x1116590", Offset = "0x1116590", VA = "0x1116590")]
		public PegasusSkyEntity(Player player, FastRandom random)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600506F")]
		[Cpp2IlInjected.Address(RVA = "0x111B59C", Offset = "0x111B59C", VA = "0x111B59C", Slot = "8")]
		public override void UpdateVelocity(int frameCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005070")]
		[Cpp2IlInjected.Address(RVA = "0x111B708", Offset = "0x111B708", VA = "0x111B708", Slot = "5")]
		public override void Update(int frameCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005071")]
		[Cpp2IlInjected.Address(RVA = "0x111B824", Offset = "0x111B824", VA = "0x111B824", Slot = "4")]
		public override Color GetColor(Color backgroundColor)
		{
			return default(Color);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A36")]
	private class VultureSkyEntity : FadingSkyEntity
	{
		[Cpp2IlInjected.Token(Token = "0x6005072")]
		[Cpp2IlInjected.Address(RVA = "0x1114D80", Offset = "0x1114D80", VA = "0x1114D80")]
		public VultureSkyEntity(Player player, FastRandom random)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005073")]
		[Cpp2IlInjected.Address(RVA = "0x111CF80", Offset = "0x111CF80", VA = "0x111CF80", Slot = "8")]
		public override void UpdateVelocity(int frameCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005074")]
		[Cpp2IlInjected.Address(RVA = "0x111D0EC", Offset = "0x111D0EC", VA = "0x111D0EC", Slot = "5")]
		public override void Update(int frameCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005075")]
		[Cpp2IlInjected.Address(RVA = "0x111D208", Offset = "0x111D208", VA = "0x111D208", Slot = "4")]
		public override Color GetColor(Color backgroundColor)
		{
			return default(Color);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A37")]
	private class PixiePosseSkyEntity : FadingSkyEntity
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4008DB5")]
		private int pixieType;

		[Cpp2IlInjected.Token(Token = "0x6005076")]
		[Cpp2IlInjected.Address(RVA = "0x1115110", Offset = "0x1115110", VA = "0x1115110")]
		public PixiePosseSkyEntity(Player player, FastRandom random)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005077")]
		[Cpp2IlInjected.Address(RVA = "0x111B8FC", Offset = "0x111B8FC", VA = "0x111B8FC", Slot = "8")]
		public override void UpdateVelocity(int frameCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005078")]
		[Cpp2IlInjected.Address(RVA = "0x111BA6C", Offset = "0x111BA6C", VA = "0x111BA6C", Slot = "5")]
		public override void Update(int frameCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005079")]
		[Cpp2IlInjected.Address(RVA = "0x111BC70", Offset = "0x111BC70", VA = "0x111BC70", Slot = "7")]
		public override void Draw(SpriteBatch spriteBatch, float depthScale, float minDepth, float maxDepth)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A38")]
	private class BirdsPackSkyEntity : FadingSkyEntity
	{
		[Cpp2IlInjected.Token(Token = "0x600507A")]
		[Cpp2IlInjected.Address(RVA = "0x1113288", Offset = "0x1113288", VA = "0x1113288")]
		public BirdsPackSkyEntity(Player player, FastRandom random)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600507B")]
		[Cpp2IlInjected.Address(RVA = "0x11186A4", Offset = "0x11186A4", VA = "0x11186A4", Slot = "8")]
		public override void UpdateVelocity(int frameCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600507C")]
		[Cpp2IlInjected.Address(RVA = "0x1118810", Offset = "0x1118810", VA = "0x1118810", Slot = "5")]
		public override void Update(int frameCount)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A39")]
	private class SeagullsGroupSkyEntity : FadingSkyEntity
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4008DB6")]
		private Vector2 _magnetAccelerations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4008DB7")]
		private Vector2 _magnetPointTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4008DB8")]
		private Vector2 _positionVsMagnet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4008DB9")]
		private Vector2 _velocityVsMagnet;

		[Cpp2IlInjected.Token(Token = "0x600507D")]
		[Cpp2IlInjected.Address(RVA = "0x111BCA8", Offset = "0x111BCA8", VA = "0x111BCA8")]
		public SeagullsGroupSkyEntity(Player player, FastRandom random)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600507E")]
		[Cpp2IlInjected.Address(RVA = "0x111C098", Offset = "0x111C098", VA = "0x111C098", Slot = "8")]
		public override void UpdateVelocity(int frameCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600507F")]
		[Cpp2IlInjected.Address(RVA = "0x111C2AC", Offset = "0x111C2AC", VA = "0x111C2AC", Slot = "5")]
		public override void Update(int frameCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005080")]
		[Cpp2IlInjected.Address(RVA = "0x111C3C8", Offset = "0x111C3C8", VA = "0x111C3C8")]
		public void SetMagnetization(Vector2 accelerations, Vector2 targetOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005081")]
		[Cpp2IlInjected.Address(RVA = "0x111C3D8", Offset = "0x111C3D8", VA = "0x111C3D8", Slot = "4")]
		public override Color GetColor(Color backgroundColor)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6005082")]
		[Cpp2IlInjected.Address(RVA = "0x111C4B0", Offset = "0x111C4B0", VA = "0x111C4B0", Slot = "7")]
		public override void Draw(SpriteBatch spriteBatch, float depthScale, float minDepth, float maxDepth)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005083")]
		[Cpp2IlInjected.Address(RVA = "0x1115508", Offset = "0x1115508", VA = "0x1115508")]
		public static List<SeagullsGroupSkyEntity> CreateGroup(Player player, FastRandom random)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A3A")]
	private class GastropodGroupSkyEntity : FadingSkyEntity
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4008DBA")]
		private Vector2 _magnetAccelerations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4008DBB")]
		private Vector2 _magnetPointTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4008DBC")]
		private Vector2 _positionVsMagnet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4008DBD")]
		private Vector2 _velocityVsMagnet;

		[Cpp2IlInjected.Token(Token = "0x6005084")]
		[Cpp2IlInjected.Address(RVA = "0x1119CA0", Offset = "0x1119CA0", VA = "0x1119CA0")]
		public GastropodGroupSkyEntity(Player player, FastRandom random)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005085")]
		[Cpp2IlInjected.Address(RVA = "0x111A038", Offset = "0x111A038", VA = "0x111A038", Slot = "8")]
		public override void UpdateVelocity(int frameCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005086")]
		[Cpp2IlInjected.Address(RVA = "0x111A304", Offset = "0x111A304", VA = "0x111A304", Slot = "5")]
		public override void Update(int frameCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005087")]
		[Cpp2IlInjected.Address(RVA = "0x111A480", Offset = "0x111A480", VA = "0x111A480", Slot = "4")]
		public override Color GetColor(Color backgroundColor)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6005088")]
		[Cpp2IlInjected.Address(RVA = "0x111A568", Offset = "0x111A568", VA = "0x111A568", Slot = "7")]
		public override void Draw(SpriteBatch spriteBatch, float depthScale, float minDepth, float maxDepth)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005089")]
		[Cpp2IlInjected.Address(RVA = "0x111A880", Offset = "0x111A880", VA = "0x111A880")]
		public void SetMagnetization(Vector2 accelerations, Vector2 targetOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600508A")]
		[Cpp2IlInjected.Address(RVA = "0x1116014", Offset = "0x1116014", VA = "0x1116014")]
		public static List<GastropodGroupSkyEntity> CreateGroup(Player player, FastRandom random)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A3B")]
	private class SlimeBalloonGroupSkyEntity : FadingSkyEntity
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4008DBE")]
		private Vector2 _magnetAccelerations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4008DBF")]
		private Vector2 _magnetPointTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4008DC0")]
		private Vector2 _positionVsMagnet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4008DC1")]
		private Vector2 _velocityVsMagnet;

		[Cpp2IlInjected.Token(Token = "0x600508B")]
		[Cpp2IlInjected.Address(RVA = "0x111C6D0", Offset = "0x111C6D0", VA = "0x111C6D0")]
		public SlimeBalloonGroupSkyEntity(Player player, FastRandom random)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600508C")]
		[Cpp2IlInjected.Address(RVA = "0x111CA78", Offset = "0x111CA78", VA = "0x111CA78", Slot = "8")]
		public override void UpdateVelocity(int frameCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600508D")]
		[Cpp2IlInjected.Address(RVA = "0x111CD3C", Offset = "0x111CD3C", VA = "0x111CD3C", Slot = "5")]
		public override void Update(int frameCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600508E")]
		[Cpp2IlInjected.Address(RVA = "0x111CF70", Offset = "0x111CF70", VA = "0x111CF70")]
		public void SetMagnetization(Vector2 accelerations, Vector2 targetOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600508F")]
		[Cpp2IlInjected.Address(RVA = "0x1115A94", Offset = "0x1115A94", VA = "0x1115A94")]
		public static List<SlimeBalloonGroupSkyEntity> CreateGroup(Player player, FastRandom random)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A3C")]
	private class HellBatsGoupSkyEntity : FadingSkyEntity
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4008DC2")]
		private Vector2 _magnetAccelerations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4008DC3")]
		private Vector2 _magnetPointTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4008DC4")]
		private Vector2 _positionVsMagnet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4008DC5")]
		private Vector2 _velocityVsMagnet;

		[Cpp2IlInjected.Token(Token = "0x6005090")]
		[Cpp2IlInjected.Address(RVA = "0x111A890", Offset = "0x111A890", VA = "0x111A890")]
		public HellBatsGoupSkyEntity(Player player, FastRandom random)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005091")]
		[Cpp2IlInjected.Address(RVA = "0x111ACB4", Offset = "0x111ACB4", VA = "0x111ACB4", Slot = "8")]
		public override void UpdateVelocity(int frameCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005092")]
		[Cpp2IlInjected.Address(RVA = "0x111AF6C", Offset = "0x111AF6C", VA = "0x111AF6C", Slot = "5")]
		public override void Update(int frameCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005093")]
		[Cpp2IlInjected.Address(RVA = "0x111AF70", Offset = "0x111AF70", VA = "0x111AF70")]
		public void SetMagnetization(Vector2 accelerations, Vector2 targetOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005094")]
		[Cpp2IlInjected.Address(RVA = "0x111AF80", Offset = "0x111AF80", VA = "0x111AF80", Slot = "4")]
		public override Color GetColor(Color backgroundColor)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6005095")]
		[Cpp2IlInjected.Address(RVA = "0x1116CC8", Offset = "0x1116CC8", VA = "0x1116CC8")]
		public static List<HellBatsGoupSkyEntity> CreateGroup(Player player, FastRandom random)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6005096")]
		[Cpp2IlInjected.Address(RVA = "0x111B048", Offset = "0x111B048", VA = "0x111B048")]
		internal float Helper_GetOpacityWithAccountingForBackgroundsOff()
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A3D")]
	private class BatsGroupSkyEntity : FadingSkyEntity
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4008DC6")]
		private Vector2 _magnetAccelerations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4008DC7")]
		private Vector2 _magnetPointTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4008DC8")]
		private Vector2 _positionVsMagnet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4008DC9")]
		private Vector2 _velocityVsMagnet;

		[Cpp2IlInjected.Token(Token = "0x6005097")]
		[Cpp2IlInjected.Address(RVA = "0x1117C30", Offset = "0x1117C30", VA = "0x1117C30")]
		public BatsGroupSkyEntity(Player player, FastRandom random)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005098")]
		[Cpp2IlInjected.Address(RVA = "0x1118088", Offset = "0x1118088", VA = "0x1118088", Slot = "8")]
		public override void UpdateVelocity(int frameCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005099")]
		[Cpp2IlInjected.Address(RVA = "0x1118340", Offset = "0x1118340", VA = "0x1118340", Slot = "5")]
		public override void Update(int frameCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600509A")]
		[Cpp2IlInjected.Address(RVA = "0x111845C", Offset = "0x111845C", VA = "0x111845C")]
		public void SetMagnetization(Vector2 accelerations, Vector2 targetOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600509B")]
		[Cpp2IlInjected.Address(RVA = "0x111846C", Offset = "0x111846C", VA = "0x111846C", Slot = "4")]
		public override Color GetColor(Color backgroundColor)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600509C")]
		[Cpp2IlInjected.Address(RVA = "0x1114048", Offset = "0x1114048", VA = "0x1114048")]
		public static List<BatsGroupSkyEntity> CreateGroup(Player player, FastRandom random)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A3E")]
	private class WyvernSkyEntity : FadingSkyEntity
	{
		[Cpp2IlInjected.Token(Token = "0x600509D")]
		[Cpp2IlInjected.Address(RVA = "0x1113CB8", Offset = "0x1113CB8", VA = "0x1113CB8")]
		public WyvernSkyEntity(Player player, FastRandom random)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600509E")]
		[Cpp2IlInjected.Address(RVA = "0x111D32C", Offset = "0x111D32C", VA = "0x111D32C", Slot = "8")]
		public override void UpdateVelocity(int frameCount)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A3F")]
	private class NormalizedBackgroundLayerSpaceSkyEntity : SkyEntity
	{
		[Cpp2IlInjected.Token(Token = "0x600509F")]
		[Cpp2IlInjected.Address(RVA = "0x111B4F4", Offset = "0x111B4F4", VA = "0x111B4F4", Slot = "4")]
		public override Color GetColor(Color backgroundColor)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60050A0")]
		[Cpp2IlInjected.Address(RVA = "0x111B584", Offset = "0x111B584", VA = "0x111B584", Slot = "6")]
		public override Vector2 GetDrawPosition()
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60050A1")]
		[Cpp2IlInjected.Address(RVA = "0x111B598", Offset = "0x111B598", VA = "0x111B598", Slot = "5")]
		public override void Update(int frameCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60050A2")]
		[Cpp2IlInjected.Address(RVA = "0x111893C", Offset = "0x111893C", VA = "0x111893C")]
		public NormalizedBackgroundLayerSpaceSkyEntity()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A40")]
	private class BoneSerpentSkyEntity : NormalizedBackgroundLayerSpaceSkyEntity
	{
		[Cpp2IlInjected.Token(Token = "0x60050A3")]
		[Cpp2IlInjected.Address(RVA = "0x111892C", Offset = "0x111892C", VA = "0x111892C")]
		public BoneSerpentSkyEntity()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A41")]
	private class AirshipSkyEntity : FadingSkyEntity
	{
		[Cpp2IlInjected.Token(Token = "0x60050A4")]
		[Cpp2IlInjected.Address(RVA = "0x1112F70", Offset = "0x1112F70", VA = "0x1112F70")]
		public AirshipSkyEntity(Player player, FastRandom random)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60050A5")]
		[Cpp2IlInjected.Address(RVA = "0x11179A8", Offset = "0x11179A8", VA = "0x11179A8", Slot = "8")]
		public override void UpdateVelocity(int frameCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60050A6")]
		[Cpp2IlInjected.Address(RVA = "0x1117B14", Offset = "0x1117B14", VA = "0x1117B14", Slot = "5")]
		public override void Update(int frameCount)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A42")]
	private class AirBalloonSkyEntity : FadingSkyEntity
	{
		[Cpp2IlInjected.Token(Token = "0x4008DCA")]
		private const int RANDOM_TILE_SPAWN_RANGE = 100;

		[Cpp2IlInjected.Token(Token = "0x60050A7")]
		[Cpp2IlInjected.Address(RVA = "0x1112BF8", Offset = "0x1112BF8", VA = "0x1112BF8")]
		public AirBalloonSkyEntity(Player player, FastRandom random)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60050A8")]
		[Cpp2IlInjected.Address(RVA = "0x1117320", Offset = "0x1117320", VA = "0x1117320", Slot = "8")]
		public override void UpdateVelocity(int frameCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60050A9")]
		[Cpp2IlInjected.Address(RVA = "0x11175D8", Offset = "0x11175D8", VA = "0x11175D8", Slot = "5")]
		public override void Update(int frameCount)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A43")]
	private class CrimeraSkyEntity : EOCSkyEntity
	{
		[Cpp2IlInjected.Token(Token = "0x60050AA")]
		[Cpp2IlInjected.Address(RVA = "0x1116AF4", Offset = "0x1116AF4", VA = "0x1116AF4")]
		public CrimeraSkyEntity(Player player, FastRandom random)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60050AB")]
		[Cpp2IlInjected.Address(RVA = "0x1118BD8", Offset = "0x1118BD8", VA = "0x1118BD8", Slot = "4")]
		public override Color GetColor(Color backgroundColor)
		{
			return default(Color);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A44")]
	private class EOSSkyEntity : EOCSkyEntity
	{
		[Cpp2IlInjected.Token(Token = "0x60050AC")]
		[Cpp2IlInjected.Address(RVA = "0x1116920", Offset = "0x1116920", VA = "0x1116920")]
		public EOSSkyEntity(Player player, FastRandom random)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60050AD")]
		[Cpp2IlInjected.Address(RVA = "0x1119304", Offset = "0x1119304", VA = "0x1119304", Slot = "4")]
		public override Color GetColor(Color backgroundColor)
		{
			return default(Color);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A45")]
	private class EOCSkyEntity : FadingSkyEntity
	{
		[Cpp2IlInjected.Token(Token = "0x4008DCB")]
		private const int STATE_ZIGZAG = 1;

		[Cpp2IlInjected.Token(Token = "0x4008DCC")]
		private const int STATE_GOOVERPLAYER = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4008DCD")]
		private int _state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4008DCE")]
		private int _direction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4008DCF")]
		private float _waviness;

		[Cpp2IlInjected.Token(Token = "0x60050AE")]
		[Cpp2IlInjected.Address(RVA = "0x1113618", Offset = "0x1113618", VA = "0x1113618")]
		public EOCSkyEntity(Player player, FastRandom random)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60050AF")]
		[Cpp2IlInjected.Address(RVA = "0x1118CB0", Offset = "0x1118CB0", VA = "0x1118CB0")]
		private void BeginZigZag(ref FastRandom random, VirtualCamera camera, int direction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60050B0")]
		[Cpp2IlInjected.Address(RVA = "0x1118DA8", Offset = "0x1118DA8", VA = "0x1118DA8")]
		private void BeginChasingPlayer(ref FastRandom random, VirtualCamera camera)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60050B1")]
		[Cpp2IlInjected.Address(RVA = "0x1118EF8", Offset = "0x1118EF8", VA = "0x1118EF8", Slot = "8")]
		public override void UpdateVelocity(int frameCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60050B2")]
		[Cpp2IlInjected.Address(RVA = "0x1118FB4", Offset = "0x1118FB4", VA = "0x1118FB4")]
		private void ZigzagMove(int frameCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60050B3")]
		[Cpp2IlInjected.Address(RVA = "0x11190A8", Offset = "0x11190A8", VA = "0x11190A8")]
		private void ChasePlayerTop(int frameCount)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A46")]
	private class MeteorSkyEntity : FadingSkyEntity
	{
		[Cpp2IlInjected.Token(Token = "0x60050B4")]
		[Cpp2IlInjected.Address(RVA = "0x1113888", Offset = "0x1113888", VA = "0x1113888")]
		public MeteorSkyEntity(Player player, FastRandom random)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A47")]
	private delegate SkyEntity EntityFactoryMethod(Player player, int seed);

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006CCB")]
	private bool _isActive;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006CCC")]
	private readonly SlotVector<SkyEntity> _entities;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4006CCD")]
	private int _frameCounter;

	[Cpp2IlInjected.Token(Token = "0x6003FCD")]
	[Cpp2IlInjected.Address(RVA = "0x1111788", Offset = "0x1111788", VA = "0x1111788", Slot = "6")]
	public override void Activate(Vector2 position, params object[] args)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FCE")]
	[Cpp2IlInjected.Address(RVA = "0x1111794", Offset = "0x1111794", VA = "0x1111794", Slot = "7")]
	public override void Deactivate(params object[] args)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FCF")]
	[Cpp2IlInjected.Address(RVA = "0x11117A0", Offset = "0x11117A0", VA = "0x11117A0")]
	private bool AnActiveSkyConflictsWithAmbience()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003FD0")]
	[Cpp2IlInjected.Address(RVA = "0x11118B0", Offset = "0x11118B0", VA = "0x11118B0", Slot = "8")]
	public override void Update(GameTime gameTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FD1")]
	[Cpp2IlInjected.Address(RVA = "0x1111F6C", Offset = "0x1111F6C", VA = "0x1111F6C", Slot = "9")]
	public override void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FD2")]
	[Cpp2IlInjected.Address(RVA = "0x111243C", Offset = "0x111243C", VA = "0x111243C", Slot = "10")]
	public override bool IsActive()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003FD3")]
	[Cpp2IlInjected.Address(RVA = "0x1112444", Offset = "0x1112444", VA = "0x1112444", Slot = "11")]
	public override void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FD4")]
	[Cpp2IlInjected.Address(RVA = "0x1112448", Offset = "0x1112448", VA = "0x1112448")]
	public void Spawn(Player player, SkyEntityType type, int seed)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003FD5")]
	[Cpp2IlInjected.Address(RVA = "0x1117240", Offset = "0x1117240", VA = "0x1117240")]
	public AmbientSky()
	{
	}
}
