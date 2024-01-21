using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.GameContent.UI.Elements;
using Terraria.UI;

namespace Terraria.GameContent.Creative;

[Cpp2IlInjected.Token(Token = "0x200068F")]
public class CreativePowers
{
	[Cpp2IlInjected.Token(Token = "0x2000A7F")]
	public abstract class APerPlayerTogglePower : ICreativePower, IOnPlayerJoining
	{
		[Cpp2IlInjected.Token(Token = "0x2000BC8")]
		private enum SubMessageType : byte
		{
			[Cpp2IlInjected.Token(Token = "0x400914A")]
			SyncEveryone,
			[Cpp2IlInjected.Token(Token = "0x400914B")]
			SyncOnePlayer
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4008E9A")]
		internal string _powerNameKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4008E9B")]
		internal Point _iconLocation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4008E9C")]
		internal bool _defaultToggleState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4008E9D")]
		private bool[] _perPlayerIsEnabled;

		[Cpp2IlInjected.Token(Token = "0x170008E9")]
		public ushort PowerId
		{
			[Cpp2IlInjected.Token(Token = "0x6005155")]
			[Cpp2IlInjected.Address(RVA = "0x1085890", Offset = "0x1085890", VA = "0x1085890", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x6005156")]
			[Cpp2IlInjected.Address(RVA = "0x1085898", Offset = "0x1085898", VA = "0x1085898", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008EA")]
		public string ServerConfigName
		{
			[Cpp2IlInjected.Token(Token = "0x6005157")]
			[Cpp2IlInjected.Address(RVA = "0x10858A0", Offset = "0x10858A0", VA = "0x10858A0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6005158")]
			[Cpp2IlInjected.Address(RVA = "0x10858A8", Offset = "0x10858A8", VA = "0x10858A8", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008EB")]
		public PowerPermissionLevel CurrentPermissionLevel
		{
			[Cpp2IlInjected.Token(Token = "0x6005159")]
			[Cpp2IlInjected.Address(RVA = "0x10858B0", Offset = "0x10858B0", VA = "0x10858B0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(PowerPermissionLevel);
			}
			[Cpp2IlInjected.Token(Token = "0x600515A")]
			[Cpp2IlInjected.Address(RVA = "0x10858B8", Offset = "0x10858B8", VA = "0x10858B8", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008EC")]
		public PowerPermissionLevel DefaultPermissionLevel
		{
			[Cpp2IlInjected.Token(Token = "0x600515B")]
			[Cpp2IlInjected.Address(RVA = "0x10858C0", Offset = "0x10858C0", VA = "0x10858C0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(PowerPermissionLevel);
			}
			[Cpp2IlInjected.Token(Token = "0x600515C")]
			[Cpp2IlInjected.Address(RVA = "0x10858C8", Offset = "0x10858C8", VA = "0x10858C8", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600515D")]
		[Cpp2IlInjected.Address(RVA = "0x10858D0", Offset = "0x10858D0", VA = "0x10858D0")]
		public bool IsEnabledForPlayer(int playerIndex)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600515E")]
		[Cpp2IlInjected.Address(RVA = "0x1085988", Offset = "0x1085988", VA = "0x1085988", Slot = "12")]
		public void DeserializeNetMessage(BinaryReader reader, int userId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600515F")]
		[Cpp2IlInjected.Address(RVA = "0x1085AD0", Offset = "0x1085AD0", VA = "0x1085AD0")]
		private void Deserialize_SyncEveryone(BinaryReader reader, int userId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005160")]
		[Cpp2IlInjected.Address(RVA = "0x1085CF0", Offset = "0x1085CF0", VA = "0x1085CF0")]
		public void SetEnabledState(int playerIndex, bool state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005161")]
		[Cpp2IlInjected.Address(RVA = "0x1085EA4", Offset = "0x1085EA4", VA = "0x1085EA4")]
		public void DebugCall()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005162")]
		[Cpp2IlInjected.Address(RVA = "0x1085EA8", Offset = "0x1085EA8", VA = "0x1085EA8")]
		internal void RequestUse()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005163")]
		[Cpp2IlInjected.Address(RVA = "0x1086064", Offset = "0x1086064", VA = "0x1086064", Slot = "16")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005164")]
		[Cpp2IlInjected.Address(RVA = "0x108609C", Offset = "0x108609C", VA = "0x108609C", Slot = "15")]
		public void OnPlayerJoining(int playerIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005165")]
		[Cpp2IlInjected.Address(RVA = "0x10862B4", Offset = "0x10862B4", VA = "0x10862B4", Slot = "13")]
		public void ProvidePowerButtons(CreativePowerUIElementRequestInfo info, List<UIElement> elements)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005166")]
		[Cpp2IlInjected.Address(RVA = "0x1086690", Offset = "0x1086690", VA = "0x1086690")]
		private void button_OnUpdate(UIElement affectedElement)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005167")]
		[Cpp2IlInjected.Address(RVA = "0x10868C4", Offset = "0x10868C4", VA = "0x10868C4")]
		private void button_OnClick(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005168")]
		[Cpp2IlInjected.Address(Slot = "17")]
		public abstract bool GetIsUnlocked();

		[Cpp2IlInjected.Token(Token = "0x6005169")]
		[Cpp2IlInjected.Address(RVA = "0x10869A8", Offset = "0x10869A8", VA = "0x10869A8")]
		protected APerPlayerTogglePower()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A80")]
	public abstract class APerPlayerSliderPower : ICreativePower, IOnPlayerJoining, IProvideSliderElement, IPowerSubcategoryElement
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4008EA2")]
		internal Point _iconLocation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4008EA3")]
		internal float _sliderCurrentValueCache;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4008EA4")]
		internal string _powerNameKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4008EA5")]
		internal float[] _cachePerPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4008EA6")]
		internal float _sliderDefaultValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4008EA7")]
		private float _currentTargetValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4008EA8")]
		private bool _needsToCommitChange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4008EA9")]
		private DateTime _nextTimeWeCanPush;

		[Cpp2IlInjected.Token(Token = "0x170008ED")]
		public ushort PowerId
		{
			[Cpp2IlInjected.Token(Token = "0x600516A")]
			[Cpp2IlInjected.Address(RVA = "0x1084464", Offset = "0x1084464", VA = "0x1084464", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x600516B")]
			[Cpp2IlInjected.Address(RVA = "0x108446C", Offset = "0x108446C", VA = "0x108446C", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008EE")]
		public string ServerConfigName
		{
			[Cpp2IlInjected.Token(Token = "0x600516C")]
			[Cpp2IlInjected.Address(RVA = "0x1084474", Offset = "0x1084474", VA = "0x1084474", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600516D")]
			[Cpp2IlInjected.Address(RVA = "0x108447C", Offset = "0x108447C", VA = "0x108447C", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008EF")]
		public PowerPermissionLevel CurrentPermissionLevel
		{
			[Cpp2IlInjected.Token(Token = "0x600516E")]
			[Cpp2IlInjected.Address(RVA = "0x1084484", Offset = "0x1084484", VA = "0x1084484", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(PowerPermissionLevel);
			}
			[Cpp2IlInjected.Token(Token = "0x600516F")]
			[Cpp2IlInjected.Address(RVA = "0x108448C", Offset = "0x108448C", VA = "0x108448C", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008F0")]
		public PowerPermissionLevel DefaultPermissionLevel
		{
			[Cpp2IlInjected.Token(Token = "0x6005170")]
			[Cpp2IlInjected.Address(RVA = "0x1084494", Offset = "0x1084494", VA = "0x1084494", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(PowerPermissionLevel);
			}
			[Cpp2IlInjected.Token(Token = "0x6005171")]
			[Cpp2IlInjected.Address(RVA = "0x108449C", Offset = "0x108449C", VA = "0x108449C", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005172")]
		[Cpp2IlInjected.Address(RVA = "0x10844A4", Offset = "0x10844A4", VA = "0x10844A4")]
		public bool GetRemappedSliderValueFor(int playerIndex, out float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6005173")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract float RemapSliderValueToPowerValue(float sliderValue);

		[Cpp2IlInjected.Token(Token = "0x6005174")]
		[Cpp2IlInjected.Address(RVA = "0x1084578", Offset = "0x1084578", VA = "0x1084578", Slot = "12")]
		public void DeserializeNetMessage(BinaryReader reader, int userId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005175")]
		[Cpp2IlInjected.Address(Slot = "19")]
		internal abstract void UpdateInfoFromSliderValueCache();

		[Cpp2IlInjected.Token(Token = "0x6005176")]
		[Cpp2IlInjected.Address(RVA = "0x1084830", Offset = "0x1084830", VA = "0x1084830", Slot = "13")]
		public void ProvidePowerButtons(CreativePowerUIElementRequestInfo info, List<UIElement> elements)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005177")]
		[Cpp2IlInjected.Address(RVA = "0x10848A8", Offset = "0x10848A8", VA = "0x10848A8")]
		public void DebugCall()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005178")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract UIElement ProvideSlider();

		[Cpp2IlInjected.Token(Token = "0x6005179")]
		[Cpp2IlInjected.Address(RVA = "0x1084A20", Offset = "0x1084A20", VA = "0x1084A20")]
		internal float GetSliderValue()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600517A")]
		[Cpp2IlInjected.Address(RVA = "0x1084AB8", Offset = "0x1084AB8", VA = "0x1084AB8")]
		internal void SetValueKeyboard(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600517B")]
		[Cpp2IlInjected.Address(RVA = "0x1084BA8", Offset = "0x1084BA8", VA = "0x1084BA8")]
		internal void SetValueGamepad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600517C")]
		[Cpp2IlInjected.Address(RVA = "0x1084BAC", Offset = "0x1084BAC", VA = "0x1084BAC")]
		public void PushChangeAndSetSlider(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600517D")]
		[Cpp2IlInjected.Address(RVA = "0x1084E6C", Offset = "0x1084E6C", VA = "0x1084E6C", Slot = "17")]
		public GroupOptionButton<int> GetOptionButton(CreativePowerUIElementRequestInfo info, int optionIndex, int currentOptionIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600517E")]
		[Cpp2IlInjected.Address(RVA = "0x10851CC", Offset = "0x10851CC", VA = "0x10851CC")]
		private void categoryButton_OnUpdate(UIElement affectedElement)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600517F")]
		[Cpp2IlInjected.Address(RVA = "0x1085614", Offset = "0x1085614", VA = "0x1085614")]
		public void AttemptPushingChange()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005180")]
		[Cpp2IlInjected.Address(RVA = "0x1084C98", Offset = "0x1084C98", VA = "0x1084C98")]
		internal void PushChange(float newSliderValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005181")]
		[Cpp2IlInjected.Address(RVA = "0x10856E4", Offset = "0x10856E4", VA = "0x10856E4", Slot = "21")]
		public virtual void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005182")]
		[Cpp2IlInjected.Address(RVA = "0x1085734", Offset = "0x1085734", VA = "0x1085734", Slot = "22")]
		public virtual void ResetForPlayer(int playerIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005183")]
		[Cpp2IlInjected.Address(RVA = "0x10857CC", Offset = "0x10857CC", VA = "0x10857CC", Slot = "15")]
		public void OnPlayerJoining(int playerIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005184")]
		[Cpp2IlInjected.Address(Slot = "23")]
		public abstract bool GetIsUnlocked();

		[Cpp2IlInjected.Token(Token = "0x6005185")]
		[Cpp2IlInjected.Address(RVA = "0x10857DC", Offset = "0x10857DC", VA = "0x10857DC")]
		protected APerPlayerSliderPower()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A81")]
	public abstract class ASharedButtonPower : ICreativePower
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4008EAE")]
		internal Point _iconLocation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4008EAF")]
		internal string _powerNameKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4008EB0")]
		internal string _descriptionKey;

		[Cpp2IlInjected.Token(Token = "0x170008F1")]
		public ushort PowerId
		{
			[Cpp2IlInjected.Token(Token = "0x6005186")]
			[Cpp2IlInjected.Address(RVA = "0x1086A14", Offset = "0x1086A14", VA = "0x1086A14", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x6005187")]
			[Cpp2IlInjected.Address(RVA = "0x1086A1C", Offset = "0x1086A1C", VA = "0x1086A1C", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008F2")]
		public string ServerConfigName
		{
			[Cpp2IlInjected.Token(Token = "0x6005188")]
			[Cpp2IlInjected.Address(RVA = "0x1086A24", Offset = "0x1086A24", VA = "0x1086A24", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6005189")]
			[Cpp2IlInjected.Address(RVA = "0x1086A2C", Offset = "0x1086A2C", VA = "0x1086A2C", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008F3")]
		public PowerPermissionLevel CurrentPermissionLevel
		{
			[Cpp2IlInjected.Token(Token = "0x600518A")]
			[Cpp2IlInjected.Address(RVA = "0x1086A34", Offset = "0x1086A34", VA = "0x1086A34", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(PowerPermissionLevel);
			}
			[Cpp2IlInjected.Token(Token = "0x600518B")]
			[Cpp2IlInjected.Address(RVA = "0x1086A3C", Offset = "0x1086A3C", VA = "0x1086A3C", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008F4")]
		public PowerPermissionLevel DefaultPermissionLevel
		{
			[Cpp2IlInjected.Token(Token = "0x600518C")]
			[Cpp2IlInjected.Address(RVA = "0x1086A44", Offset = "0x1086A44", VA = "0x1086A44", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(PowerPermissionLevel);
			}
			[Cpp2IlInjected.Token(Token = "0x600518D")]
			[Cpp2IlInjected.Address(RVA = "0x1086A4C", Offset = "0x1086A4C", VA = "0x1086A4C", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600518E")]
		[Cpp2IlInjected.Address(RVA = "0x1086A54", Offset = "0x1086A54", VA = "0x1086A54")]
		public ASharedButtonPower()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600518F")]
		[Cpp2IlInjected.Address(RVA = "0x1086A80", Offset = "0x1086A80", VA = "0x1086A80")]
		public void RequestUse()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005190")]
		[Cpp2IlInjected.Address(RVA = "0x1086B64", Offset = "0x1086B64", VA = "0x1086B64", Slot = "12")]
		public void DeserializeNetMessage(BinaryReader reader, int userId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005191")]
		[Cpp2IlInjected.Address(Slot = "15")]
		internal abstract void UsePower();

		[Cpp2IlInjected.Token(Token = "0x6005192")]
		[Cpp2IlInjected.Address(Slot = "16")]
		internal abstract void OnCreation();

		[Cpp2IlInjected.Token(Token = "0x6005193")]
		[Cpp2IlInjected.Address(RVA = "0x1086C40", Offset = "0x1086C40", VA = "0x1086C40", Slot = "13")]
		public void ProvidePowerButtons(CreativePowerUIElementRequestInfo info, List<UIElement> elements)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005194")]
		[Cpp2IlInjected.Address(RVA = "0x1086F90", Offset = "0x1086F90", VA = "0x1086F90")]
		private void button_OnUpdate(UIElement affectedElement)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005195")]
		[Cpp2IlInjected.Address(RVA = "0x1087100", Offset = "0x1087100", VA = "0x1087100")]
		private void button_OnClick(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005196")]
		[Cpp2IlInjected.Address(Slot = "17")]
		public abstract bool GetIsUnlocked();
	}

	[Cpp2IlInjected.Token(Token = "0x2000A82")]
	public abstract class ASharedTogglePower : ICreativePower, IOnPlayerJoining
	{
		[Cpp2IlInjected.Token(Token = "0x170008F5")]
		public ushort PowerId
		{
			[Cpp2IlInjected.Token(Token = "0x6005197")]
			[Cpp2IlInjected.Address(RVA = "0x1087E84", Offset = "0x1087E84", VA = "0x1087E84", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x6005198")]
			[Cpp2IlInjected.Address(RVA = "0x1087E8C", Offset = "0x1087E8C", VA = "0x1087E8C", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008F6")]
		public string ServerConfigName
		{
			[Cpp2IlInjected.Token(Token = "0x6005199")]
			[Cpp2IlInjected.Address(RVA = "0x1087E94", Offset = "0x1087E94", VA = "0x1087E94", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600519A")]
			[Cpp2IlInjected.Address(RVA = "0x1087E9C", Offset = "0x1087E9C", VA = "0x1087E9C", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008F7")]
		public PowerPermissionLevel CurrentPermissionLevel
		{
			[Cpp2IlInjected.Token(Token = "0x600519B")]
			[Cpp2IlInjected.Address(RVA = "0x1087EA4", Offset = "0x1087EA4", VA = "0x1087EA4", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(PowerPermissionLevel);
			}
			[Cpp2IlInjected.Token(Token = "0x600519C")]
			[Cpp2IlInjected.Address(RVA = "0x1087EAC", Offset = "0x1087EAC", VA = "0x1087EAC", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008F8")]
		public PowerPermissionLevel DefaultPermissionLevel
		{
			[Cpp2IlInjected.Token(Token = "0x600519D")]
			[Cpp2IlInjected.Address(RVA = "0x1087EB4", Offset = "0x1087EB4", VA = "0x1087EB4", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(PowerPermissionLevel);
			}
			[Cpp2IlInjected.Token(Token = "0x600519E")]
			[Cpp2IlInjected.Address(RVA = "0x1087EBC", Offset = "0x1087EBC", VA = "0x1087EBC", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008F9")]
		public bool Enabled
		{
			[Cpp2IlInjected.Token(Token = "0x600519F")]
			[Cpp2IlInjected.Address(RVA = "0x1087EC4", Offset = "0x1087EC4", VA = "0x1087EC4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60051A0")]
			[Cpp2IlInjected.Address(RVA = "0x1087ECC", Offset = "0x1087ECC", VA = "0x1087ECC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60051A1")]
		[Cpp2IlInjected.Address(RVA = "0x1087ED4", Offset = "0x1087ED4", VA = "0x1087ED4")]
		public void SetPowerInfo(bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60051A2")]
		[Cpp2IlInjected.Address(RVA = "0x1087EDC", Offset = "0x1087EDC", VA = "0x1087EDC", Slot = "16")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60051A3")]
		[Cpp2IlInjected.Address(RVA = "0x1087EE8", Offset = "0x1087EE8", VA = "0x1087EE8", Slot = "15")]
		public void OnPlayerJoining(int playerIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60051A4")]
		[Cpp2IlInjected.Address(RVA = "0x1088008", Offset = "0x1088008", VA = "0x1088008", Slot = "12")]
		public void DeserializeNetMessage(BinaryReader reader, int userId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60051A5")]
		[Cpp2IlInjected.Address(RVA = "0x10881FC", Offset = "0x10881FC", VA = "0x10881FC")]
		public void RequestUse()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60051A6")]
		[Cpp2IlInjected.Address(RVA = "0x1088320", Offset = "0x1088320", VA = "0x1088320", Slot = "13")]
		public void ProvidePowerButtons(CreativePowerUIElementRequestInfo info, List<UIElement> elements)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60051A7")]
		[Cpp2IlInjected.Address(RVA = "0x10884B4", Offset = "0x10884B4", VA = "0x10884B4")]
		private void button_OnUpdate(UIElement affectedElement)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60051A8")]
		[Cpp2IlInjected.Address(RVA = "0x10886CC", Offset = "0x10886CC", VA = "0x10886CC")]
		private void button_OnClick(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60051A9")]
		[Cpp2IlInjected.Address(Slot = "17")]
		internal abstract void CustomizeButton(UIElement button);

		[Cpp2IlInjected.Token(Token = "0x60051AA")]
		[Cpp2IlInjected.Address(Slot = "18")]
		internal abstract string GetButtonTextKey();

		[Cpp2IlInjected.Token(Token = "0x60051AB")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract bool GetIsUnlocked();

		[Cpp2IlInjected.Token(Token = "0x60051AC")]
		[Cpp2IlInjected.Address(RVA = "0x1088790", Offset = "0x1088790", VA = "0x1088790")]
		protected ASharedTogglePower()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A83")]
	public abstract class ASharedSliderPower : ICreativePower, IOnPlayerJoining, IProvideSliderElement, IPowerSubcategoryElement
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4008EBA")]
		internal Point _iconLocation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4008EBB")]
		internal float _sliderCurrentValueCache;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4008EBC")]
		internal string _powerNameKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4008EBD")]
		internal bool _syncToJoiningPlayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4008EBE")]
		internal float _currentTargetValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4008EBF")]
		private bool _needsToCommitChange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4008EC0")]
		private DateTime _nextTimeWeCanPush;

		[Cpp2IlInjected.Token(Token = "0x170008FA")]
		public ushort PowerId
		{
			[Cpp2IlInjected.Token(Token = "0x60051AD")]
			[Cpp2IlInjected.Address(RVA = "0x10871C4", Offset = "0x10871C4", VA = "0x10871C4", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60051AE")]
			[Cpp2IlInjected.Address(RVA = "0x10871CC", Offset = "0x10871CC", VA = "0x10871CC", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008FB")]
		public string ServerConfigName
		{
			[Cpp2IlInjected.Token(Token = "0x60051AF")]
			[Cpp2IlInjected.Address(RVA = "0x10871D4", Offset = "0x10871D4", VA = "0x10871D4", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60051B0")]
			[Cpp2IlInjected.Address(RVA = "0x10871DC", Offset = "0x10871DC", VA = "0x10871DC", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008FC")]
		public PowerPermissionLevel CurrentPermissionLevel
		{
			[Cpp2IlInjected.Token(Token = "0x60051B1")]
			[Cpp2IlInjected.Address(RVA = "0x10871E4", Offset = "0x10871E4", VA = "0x10871E4", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(PowerPermissionLevel);
			}
			[Cpp2IlInjected.Token(Token = "0x60051B2")]
			[Cpp2IlInjected.Address(RVA = "0x10871EC", Offset = "0x10871EC", VA = "0x10871EC", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008FD")]
		public PowerPermissionLevel DefaultPermissionLevel
		{
			[Cpp2IlInjected.Token(Token = "0x60051B3")]
			[Cpp2IlInjected.Address(RVA = "0x10871F4", Offset = "0x10871F4", VA = "0x10871F4", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(PowerPermissionLevel);
			}
			[Cpp2IlInjected.Token(Token = "0x60051B4")]
			[Cpp2IlInjected.Address(RVA = "0x10871FC", Offset = "0x10871FC", VA = "0x10871FC", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60051B5")]
		[Cpp2IlInjected.Address(RVA = "0x1087204", Offset = "0x1087204", VA = "0x1087204", Slot = "12")]
		public void DeserializeNetMessage(BinaryReader reader, int userId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60051B6")]
		[Cpp2IlInjected.Address(Slot = "18")]
		internal abstract void UpdateInfoFromSliderValueCache();

		[Cpp2IlInjected.Token(Token = "0x60051B7")]
		[Cpp2IlInjected.Address(RVA = "0x1087410", Offset = "0x1087410", VA = "0x1087410", Slot = "13")]
		public void ProvidePowerButtons(CreativePowerUIElementRequestInfo info, List<UIElement> elements)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60051B8")]
		[Cpp2IlInjected.Address(RVA = "0x1087488", Offset = "0x1087488", VA = "0x1087488")]
		public void DebugCall()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60051B9")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract UIElement ProvideSlider();

		[Cpp2IlInjected.Token(Token = "0x60051BA")]
		[Cpp2IlInjected.Address(RVA = "0x10875A4", Offset = "0x10875A4", VA = "0x10875A4")]
		internal float GetSliderValue()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60051BB")]
		[Cpp2IlInjected.Address(RVA = "0x1087648", Offset = "0x1087648", VA = "0x1087648", Slot = "20")]
		internal virtual float GetSliderValueInner()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60051BC")]
		[Cpp2IlInjected.Address(RVA = "0x1087650", Offset = "0x1087650", VA = "0x1087650")]
		internal void SetValueKeyboard(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60051BD")]
		[Cpp2IlInjected.Address(RVA = "0x10876BC", Offset = "0x10876BC", VA = "0x10876BC")]
		internal void SetValueKeyboardForced(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60051BE")]
		[Cpp2IlInjected.Address(RVA = "0x1087788", Offset = "0x1087788", VA = "0x1087788")]
		internal void SetValueGamepad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60051BF")]
		[Cpp2IlInjected.Address(RVA = "0x108778C", Offset = "0x108778C", VA = "0x108778C", Slot = "17")]
		public GroupOptionButton<int> GetOptionButton(CreativePowerUIElementRequestInfo info, int optionIndex, int currentOptionIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60051C0")]
		[Cpp2IlInjected.Address(RVA = "0x10878BC", Offset = "0x10878BC", VA = "0x10878BC")]
		private void categoryButton_OnUpdate(UIElement affectedElement)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60051C1")]
		[Cpp2IlInjected.Address(RVA = "0x1087ACC", Offset = "0x1087ACC", VA = "0x1087ACC")]
		public void AttemptPushingChange()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60051C2")]
		[Cpp2IlInjected.Address(RVA = "0x1087CAC", Offset = "0x1087CAC", VA = "0x1087CAC", Slot = "21")]
		public virtual void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60051C3")]
		[Cpp2IlInjected.Address(RVA = "0x1087CB8", Offset = "0x1087CB8", VA = "0x1087CB8", Slot = "15")]
		public void OnPlayerJoining(int playerIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60051C4")]
		[Cpp2IlInjected.Address(Slot = "22")]
		public abstract bool GetIsUnlocked();

		[Cpp2IlInjected.Token(Token = "0x60051C5")]
		[Cpp2IlInjected.Address(RVA = "0x1087DE4", Offset = "0x1087DE4", VA = "0x1087DE4")]
		protected ASharedSliderPower()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A84")]
	public class GodmodePower : APerPlayerTogglePower, IPersistentPerPlayerContent
	{
		[Cpp2IlInjected.Token(Token = "0x60051C6")]
		[Cpp2IlInjected.Address(RVA = "0x108A250", Offset = "0x108A250", VA = "0x108A250")]
		public GodmodePower()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60051C7")]
		[Cpp2IlInjected.Address(RVA = "0x108A2F4", Offset = "0x108A2F4", VA = "0x108A2F4", Slot = "17")]
		public override bool GetIsUnlocked()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60051C8")]
		[Cpp2IlInjected.Address(RVA = "0x108A2FC", Offset = "0x108A2FC", VA = "0x108A2FC", Slot = "18")]
		public void Save(Player player, BinaryWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60051C9")]
		[Cpp2IlInjected.Address(RVA = "0x108A39C", Offset = "0x108A39C", VA = "0x108A39C", Slot = "21")]
		public void ResetDataForNewPlayer(Player player)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60051CA")]
		[Cpp2IlInjected.Address(RVA = "0x108A3AC", Offset = "0x108A3AC", VA = "0x108A3AC", Slot = "19")]
		public void Load(Player player, BinaryReader reader, int gameVersionSaveWasMadeOn)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60051CB")]
		[Cpp2IlInjected.Address(RVA = "0x108A3D8", Offset = "0x108A3D8", VA = "0x108A3D8", Slot = "20")]
		public void ApplyLoadedDataToOutOfPlayerFields(Player player)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A85")]
	public class FarPlacementRangePower : APerPlayerTogglePower, IPersistentPerPlayerContent
	{
		[Cpp2IlInjected.Token(Token = "0x60051CC")]
		[Cpp2IlInjected.Address(RVA = "0x1089B48", Offset = "0x1089B48", VA = "0x1089B48")]
		public FarPlacementRangePower()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60051CD")]
		[Cpp2IlInjected.Address(RVA = "0x1089C94", Offset = "0x1089C94", VA = "0x1089C94", Slot = "17")]
		public override bool GetIsUnlocked()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60051CE")]
		[Cpp2IlInjected.Address(RVA = "0x1089C9C", Offset = "0x1089C9C", VA = "0x1089C9C", Slot = "18")]
		public void Save(Player player, BinaryWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60051CF")]
		[Cpp2IlInjected.Address(RVA = "0x1089D3C", Offset = "0x1089D3C", VA = "0x1089D3C", Slot = "21")]
		public void ResetDataForNewPlayer(Player player)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60051D0")]
		[Cpp2IlInjected.Address(RVA = "0x1089D4C", Offset = "0x1089D4C", VA = "0x1089D4C", Slot = "19")]
		public void Load(Player player, BinaryReader reader, int gameVersionSaveWasMadeOn)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60051D1")]
		[Cpp2IlInjected.Address(RVA = "0x1089D78", Offset = "0x1089D78", VA = "0x1089D78", Slot = "20")]
		public void ApplyLoadedDataToOutOfPlayerFields(Player player)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A86")]
	public class StartDayImmediately : ASharedButtonPower
	{
		[Cpp2IlInjected.Token(Token = "0x60051D2")]
		[Cpp2IlInjected.Address(RVA = "0x108D5C0", Offset = "0x108D5C0", VA = "0x108D5C0", Slot = "15")]
		internal override void UsePower()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60051D3")]
		[Cpp2IlInjected.Address(RVA = "0x108D66C", Offset = "0x108D66C", VA = "0x108D66C", Slot = "16")]
		internal override void OnCreation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60051D4")]
		[Cpp2IlInjected.Address(RVA = "0x108D724", Offset = "0x108D724", VA = "0x108D724", Slot = "17")]
		public override bool GetIsUnlocked()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60051D5")]
		[Cpp2IlInjected.Address(RVA = "0x108D72C", Offset = "0x108D72C", VA = "0x108D72C")]
		public StartDayImmediately()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A87")]
	public class StartNightImmediately : ASharedButtonPower
	{
		[Cpp2IlInjected.Token(Token = "0x60051D6")]
		[Cpp2IlInjected.Address(RVA = "0x108D8F0", Offset = "0x108D8F0", VA = "0x108D8F0", Slot = "15")]
		internal override void UsePower()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60051D7")]
		[Cpp2IlInjected.Address(RVA = "0x108D99C", Offset = "0x108D99C", VA = "0x108D99C", Slot = "16")]
		internal override void OnCreation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60051D8")]
		[Cpp2IlInjected.Address(RVA = "0x108DA54", Offset = "0x108DA54", VA = "0x108DA54", Slot = "17")]
		public override bool GetIsUnlocked()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60051D9")]
		[Cpp2IlInjected.Address(RVA = "0x108DA5C", Offset = "0x108DA5C", VA = "0x108DA5C")]
		public StartNightImmediately()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A88")]
	public class StartNoonImmediately : ASharedButtonPower
	{
		[Cpp2IlInjected.Token(Token = "0x60051DA")]
		[Cpp2IlInjected.Address(RVA = "0x108DA88", Offset = "0x108DA88", VA = "0x108DA88", Slot = "15")]
		internal override void UsePower()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60051DB")]
		[Cpp2IlInjected.Address(RVA = "0x108DB34", Offset = "0x108DB34", VA = "0x108DB34", Slot = "16")]
		internal override void OnCreation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60051DC")]
		[Cpp2IlInjected.Address(RVA = "0x108DBEC", Offset = "0x108DBEC", VA = "0x108DBEC", Slot = "17")]
		public override bool GetIsUnlocked()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60051DD")]
		[Cpp2IlInjected.Address(RVA = "0x108DBF4", Offset = "0x108DBF4", VA = "0x108DBF4")]
		public StartNoonImmediately()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A89")]
	public class StartMidnightImmediately : ASharedButtonPower
	{
		[Cpp2IlInjected.Token(Token = "0x60051DE")]
		[Cpp2IlInjected.Address(RVA = "0x108D758", Offset = "0x108D758", VA = "0x108D758", Slot = "15")]
		internal override void UsePower()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60051DF")]
		[Cpp2IlInjected.Address(RVA = "0x108D804", Offset = "0x108D804", VA = "0x108D804", Slot = "16")]
		internal override void OnCreation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60051E0")]
		[Cpp2IlInjected.Address(RVA = "0x108D8BC", Offset = "0x108D8BC", VA = "0x108D8BC", Slot = "17")]
		public override bool GetIsUnlocked()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60051E1")]
		[Cpp2IlInjected.Address(RVA = "0x108D8C4", Offset = "0x108D8C4", VA = "0x108D8C4")]
		public StartMidnightImmediately()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A8A")]
	public class ModifyTimeRate : ASharedSliderPower, IPersistentPerWorldContent
	{
		[Cpp2IlInjected.Token(Token = "0x170008FE")]
		public int TargetTimeRate
		{
			[Cpp2IlInjected.Token(Token = "0x60051E2")]
			[Cpp2IlInjected.Address(RVA = "0x108AFAC", Offset = "0x108AFAC", VA = "0x108AFAC")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60051E3")]
			[Cpp2IlInjected.Address(RVA = "0x108AFB4", Offset = "0x108AFB4", VA = "0x108AFB4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60051E4")]
		[Cpp2IlInjected.Address(RVA = "0x108AFBC", Offset = "0x108AFBC", VA = "0x108AFBC")]
		public ModifyTimeRate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60051E5")]
		[Cpp2IlInjected.Address(RVA = "0x108B05C", Offset = "0x108B05C", VA = "0x108B05C", Slot = "21")]
		public override void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60051E6")]
		[Cpp2IlInjected.Address(RVA = "0x108B070", Offset = "0x108B070", VA = "0x108B070", Slot = "18")]
		internal override void UpdateInfoFromSliderValueCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60051E7")]
		[Cpp2IlInjected.Address(RVA = "0x108B1EC", Offset = "0x108B1EC", VA = "0x108B1EC", Slot = "19")]
		public override UIElement ProvideSlider()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60051E8")]
		[Cpp2IlInjected.Address(RVA = "0x108B770", Offset = "0x108B770", VA = "0x108B770")]
		private void bottomText_OnClick(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60051E9")]
		[Cpp2IlInjected.Address(RVA = "0x108B7B0", Offset = "0x108B7B0", VA = "0x108B7B0")]
		private void middleText_OnClick(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60051EA")]
		[Cpp2IlInjected.Address(RVA = "0x108B7F4", Offset = "0x108B7F4", VA = "0x108B7F4")]
		private void topText_OnClick(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60051EB")]
		[Cpp2IlInjected.Address(RVA = "0x108B838", Offset = "0x108B838", VA = "0x108B838")]
		private void Button_OnMouseOut(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60051EC")]
		[Cpp2IlInjected.Address(RVA = "0x108B928", Offset = "0x108B928", VA = "0x108B928")]
		private void Button_OnMouseOver(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60051ED")]
		[Cpp2IlInjected.Address(RVA = "0x108BA18", Offset = "0x108BA18", VA = "0x108BA18", Slot = "22")]
		public override bool GetIsUnlocked()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60051EE")]
		[Cpp2IlInjected.Address(RVA = "0x108BA20", Offset = "0x108BA20", VA = "0x108BA20", Slot = "23")]
		public void Save(BinaryWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60051EF")]
		[Cpp2IlInjected.Address(RVA = "0x108BA3C", Offset = "0x108BA3C", VA = "0x108BA3C", Slot = "24")]
		public void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60051F0")]
		[Cpp2IlInjected.Address(RVA = "0x108BA7C", Offset = "0x108BA7C", VA = "0x108BA7C", Slot = "25")]
		public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60051F1")]
		[Cpp2IlInjected.Address(RVA = "0x108BA90", Offset = "0x108BA90", VA = "0x108BA90")]
		private void UpdateSliderAndShowMultiplierMouseOver(UIElement affectedElement)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A8B")]
	public class DifficultySliderPower : ASharedSliderPower, IPersistentPerWorldContent
	{
		[Cpp2IlInjected.Token(Token = "0x170008FF")]
		public float StrengthMultiplierToGiveNPCs
		{
			[Cpp2IlInjected.Token(Token = "0x60051F2")]
			[Cpp2IlInjected.Address(RVA = "0x1088798", Offset = "0x1088798", VA = "0x1088798")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60051F3")]
			[Cpp2IlInjected.Address(RVA = "0x10887A0", Offset = "0x10887A0", VA = "0x10887A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60051F4")]
		[Cpp2IlInjected.Address(RVA = "0x10887A8", Offset = "0x10887A8", VA = "0x10887A8")]
		public DifficultySliderPower()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60051F5")]
		[Cpp2IlInjected.Address(RVA = "0x1088848", Offset = "0x1088848", VA = "0x1088848", Slot = "21")]
		public override void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60051F6")]
		[Cpp2IlInjected.Address(RVA = "0x1088860", Offset = "0x1088860", VA = "0x1088860", Slot = "18")]
		internal override void UpdateInfoFromSliderValueCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60051F7")]
		[Cpp2IlInjected.Address(RVA = "0x1088A4C", Offset = "0x1088A4C", VA = "0x1088A4C", Slot = "19")]
		public override UIElement ProvideSlider()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60051F8")]
		[Cpp2IlInjected.Address(RVA = "0x10892C4", Offset = "0x10892C4", VA = "0x10892C4")]
		private void Click_Master(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60051F9")]
		[Cpp2IlInjected.Address(RVA = "0x1089308", Offset = "0x1089308", VA = "0x1089308")]
		private void Click_Expert(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60051FA")]
		[Cpp2IlInjected.Address(RVA = "0x1089350", Offset = "0x1089350", VA = "0x1089350")]
		private void Click_Normal(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60051FB")]
		[Cpp2IlInjected.Address(RVA = "0x1089398", Offset = "0x1089398", VA = "0x1089398")]
		private void Click_Journey(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60051FC")]
		[Cpp2IlInjected.Address(RVA = "0x1089030", Offset = "0x1089030", VA = "0x1089030")]
		private static void AddIndication(UIPanel panel, float yAnchor, string indicationText, string iconImagePath, UIElement.ElementEvent updateEvent, UIElement.MouseEvent clickEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60051FD")]
		[Cpp2IlInjected.Address(RVA = "0x10893D8", Offset = "0x10893D8", VA = "0x10893D8")]
		private static void Button_OnMouseOver(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60051FE")]
		[Cpp2IlInjected.Address(RVA = "0x1089414", Offset = "0x1089414", VA = "0x1089414")]
		private static void Button_OnMouseOut(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60051FF")]
		[Cpp2IlInjected.Address(RVA = "0x1089450", Offset = "0x1089450", VA = "0x1089450")]
		private void MouseOver_Journey(UIElement affectedElement)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005200")]
		[Cpp2IlInjected.Address(RVA = "0x108952C", Offset = "0x108952C", VA = "0x108952C")]
		private void MouseOver_Normal(UIElement affectedElement)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005201")]
		[Cpp2IlInjected.Address(RVA = "0x1089608", Offset = "0x1089608", VA = "0x1089608")]
		private void MouseOver_Expert(UIElement affectedElement)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005202")]
		[Cpp2IlInjected.Address(RVA = "0x10896E4", Offset = "0x10896E4", VA = "0x10896E4")]
		private void MouseOver_Master(UIElement affectedElement)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005203")]
		[Cpp2IlInjected.Address(RVA = "0x10897C0", Offset = "0x10897C0", VA = "0x10897C0")]
		private void UpdateSliderColorAndShowMultiplierMouseOver(UIElement affectedElement)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005204")]
		[Cpp2IlInjected.Address(RVA = "0x1089AD0", Offset = "0x1089AD0", VA = "0x1089AD0", Slot = "22")]
		public override bool GetIsUnlocked()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6005205")]
		[Cpp2IlInjected.Address(RVA = "0x1089AD8", Offset = "0x1089AD8", VA = "0x1089AD8", Slot = "23")]
		public void Save(BinaryWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005206")]
		[Cpp2IlInjected.Address(RVA = "0x1089AF4", Offset = "0x1089AF4", VA = "0x1089AF4", Slot = "24")]
		public void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005207")]
		[Cpp2IlInjected.Address(RVA = "0x1089B34", Offset = "0x1089B34", VA = "0x1089B34", Slot = "25")]
		public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A8C")]
	public class ModifyWindDirectionAndStrength : ASharedSliderPower
	{
		[Cpp2IlInjected.Token(Token = "0x6005208")]
		[Cpp2IlInjected.Address(RVA = "0x108BBD0", Offset = "0x108BBD0", VA = "0x108BBD0")]
		public ModifyWindDirectionAndStrength()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005209")]
		[Cpp2IlInjected.Address(RVA = "0x108BC78", Offset = "0x108BC78", VA = "0x108BC78", Slot = "18")]
		internal override void UpdateInfoFromSliderValueCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600520A")]
		[Cpp2IlInjected.Address(RVA = "0x108BD34", Offset = "0x108BD34", VA = "0x108BD34", Slot = "20")]
		internal override float GetSliderValueInner()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600520B")]
		[Cpp2IlInjected.Address(RVA = "0x108BE18", Offset = "0x108BE18", VA = "0x108BE18", Slot = "22")]
		public override bool GetIsUnlocked()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600520C")]
		[Cpp2IlInjected.Address(RVA = "0x108BE20", Offset = "0x108BE20", VA = "0x108BE20", Slot = "19")]
		public override UIElement ProvideSlider()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600520D")]
		[Cpp2IlInjected.Address(RVA = "0x108C3C8", Offset = "0x108C3C8", VA = "0x108C3C8")]
		private void topText_OnClick(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600520E")]
		[Cpp2IlInjected.Address(RVA = "0x108C40C", Offset = "0x108C40C", VA = "0x108C40C")]
		private void bottomText_OnClick(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600520F")]
		[Cpp2IlInjected.Address(RVA = "0x108C44C", Offset = "0x108C44C", VA = "0x108C44C")]
		private void middleText_OnClick(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005210")]
		[Cpp2IlInjected.Address(RVA = "0x108C490", Offset = "0x108C490", VA = "0x108C490")]
		private void Button_OnMouseOut(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005211")]
		[Cpp2IlInjected.Address(RVA = "0x108C580", Offset = "0x108C580", VA = "0x108C580")]
		private void Button_OnMouseOver(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005212")]
		[Cpp2IlInjected.Address(RVA = "0x108C670", Offset = "0x108C670", VA = "0x108C670")]
		private void UpdateSliderAndShowMultiplierMouseOver(UIElement affectedElement)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A8D")]
	public class ModifyRainPower : ASharedSliderPower
	{
		[Cpp2IlInjected.Token(Token = "0x6005213")]
		[Cpp2IlInjected.Address(RVA = "0x108A418", Offset = "0x108A418", VA = "0x108A418")]
		public ModifyRainPower()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005214")]
		[Cpp2IlInjected.Address(RVA = "0x108A4C0", Offset = "0x108A4C0", VA = "0x108A4C0", Slot = "18")]
		internal override void UpdateInfoFromSliderValueCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005215")]
		[Cpp2IlInjected.Address(RVA = "0x108A5AC", Offset = "0x108A5AC", VA = "0x108A5AC", Slot = "20")]
		internal override float GetSliderValueInner()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6005216")]
		[Cpp2IlInjected.Address(RVA = "0x108A624", Offset = "0x108A624", VA = "0x108A624", Slot = "22")]
		public override bool GetIsUnlocked()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6005217")]
		[Cpp2IlInjected.Address(RVA = "0x108A62C", Offset = "0x108A62C", VA = "0x108A62C", Slot = "19")]
		public override UIElement ProvideSlider()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6005218")]
		[Cpp2IlInjected.Address(RVA = "0x108ABD4", Offset = "0x108ABD4", VA = "0x108ABD4")]
		private void topText_OnClick(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005219")]
		[Cpp2IlInjected.Address(RVA = "0x108AC18", Offset = "0x108AC18", VA = "0x108AC18")]
		private void middleText_OnClick(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600521A")]
		[Cpp2IlInjected.Address(RVA = "0x108AC5C", Offset = "0x108AC5C", VA = "0x108AC5C")]
		private void bottomText_OnClick(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600521B")]
		[Cpp2IlInjected.Address(RVA = "0x108AC9C", Offset = "0x108AC9C", VA = "0x108AC9C")]
		private void Button_OnMouseOut(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600521C")]
		[Cpp2IlInjected.Address(RVA = "0x108AD8C", Offset = "0x108AD8C", VA = "0x108AD8C")]
		private void Button_OnMouseOver(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600521D")]
		[Cpp2IlInjected.Address(RVA = "0x108AE7C", Offset = "0x108AE7C", VA = "0x108AE7C")]
		private void UpdateSliderAndShowMultiplierMouseOver(UIElement affectedElement)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A8E")]
	public class FreezeTime : ASharedTogglePower, IPersistentPerWorldContent
	{
		[Cpp2IlInjected.Token(Token = "0x600521E")]
		[Cpp2IlInjected.Address(RVA = "0x1089F40", Offset = "0x1089F40", VA = "0x1089F40", Slot = "17")]
		internal override void CustomizeButton(UIElement button)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600521F")]
		[Cpp2IlInjected.Address(RVA = "0x108A00C", Offset = "0x108A00C", VA = "0x108A00C", Slot = "18")]
		internal override string GetButtonTextKey()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6005220")]
		[Cpp2IlInjected.Address(RVA = "0x108A05C", Offset = "0x108A05C", VA = "0x108A05C", Slot = "19")]
		public override bool GetIsUnlocked()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6005221")]
		[Cpp2IlInjected.Address(RVA = "0x108A064", Offset = "0x108A064", VA = "0x108A064", Slot = "20")]
		public void Save(BinaryWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005222")]
		[Cpp2IlInjected.Address(RVA = "0x108A080", Offset = "0x108A080", VA = "0x108A080", Slot = "21")]
		public void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005223")]
		[Cpp2IlInjected.Address(RVA = "0x108A0AC", Offset = "0x108A0AC", VA = "0x108A0AC", Slot = "22")]
		public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005224")]
		[Cpp2IlInjected.Address(RVA = "0x108A0C0", Offset = "0x108A0C0", VA = "0x108A0C0")]
		public FreezeTime()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A8F")]
	public class FreezeWindDirectionAndStrength : ASharedTogglePower, IPersistentPerWorldContent
	{
		[Cpp2IlInjected.Token(Token = "0x6005225")]
		[Cpp2IlInjected.Address(RVA = "0x108A0C8", Offset = "0x108A0C8", VA = "0x108A0C8", Slot = "17")]
		internal override void CustomizeButton(UIElement button)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005226")]
		[Cpp2IlInjected.Address(RVA = "0x108A194", Offset = "0x108A194", VA = "0x108A194", Slot = "18")]
		internal override string GetButtonTextKey()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6005227")]
		[Cpp2IlInjected.Address(RVA = "0x108A1E4", Offset = "0x108A1E4", VA = "0x108A1E4", Slot = "19")]
		public override bool GetIsUnlocked()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6005228")]
		[Cpp2IlInjected.Address(RVA = "0x108A1EC", Offset = "0x108A1EC", VA = "0x108A1EC", Slot = "20")]
		public void Save(BinaryWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005229")]
		[Cpp2IlInjected.Address(RVA = "0x108A208", Offset = "0x108A208", VA = "0x108A208", Slot = "21")]
		public void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600522A")]
		[Cpp2IlInjected.Address(RVA = "0x108A234", Offset = "0x108A234", VA = "0x108A234", Slot = "22")]
		public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600522B")]
		[Cpp2IlInjected.Address(RVA = "0x108A248", Offset = "0x108A248", VA = "0x108A248")]
		public FreezeWindDirectionAndStrength()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A90")]
	public class FreezeRainPower : ASharedTogglePower, IPersistentPerWorldContent
	{
		[Cpp2IlInjected.Token(Token = "0x600522C")]
		[Cpp2IlInjected.Address(RVA = "0x1089DB8", Offset = "0x1089DB8", VA = "0x1089DB8", Slot = "17")]
		internal override void CustomizeButton(UIElement button)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600522D")]
		[Cpp2IlInjected.Address(RVA = "0x1089E84", Offset = "0x1089E84", VA = "0x1089E84", Slot = "18")]
		internal override string GetButtonTextKey()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600522E")]
		[Cpp2IlInjected.Address(RVA = "0x1089ED4", Offset = "0x1089ED4", VA = "0x1089ED4", Slot = "19")]
		public override bool GetIsUnlocked()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600522F")]
		[Cpp2IlInjected.Address(RVA = "0x1089EDC", Offset = "0x1089EDC", VA = "0x1089EDC", Slot = "20")]
		public void Save(BinaryWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005230")]
		[Cpp2IlInjected.Address(RVA = "0x1089EF8", Offset = "0x1089EF8", VA = "0x1089EF8", Slot = "21")]
		public void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005231")]
		[Cpp2IlInjected.Address(RVA = "0x1089F24", Offset = "0x1089F24", VA = "0x1089F24", Slot = "22")]
		public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005232")]
		[Cpp2IlInjected.Address(RVA = "0x1089F38", Offset = "0x1089F38", VA = "0x1089F38")]
		public FreezeRainPower()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A91")]
	public class StopBiomeSpreadPower : ASharedTogglePower, IPersistentPerWorldContent
	{
		[Cpp2IlInjected.Token(Token = "0x6005233")]
		[Cpp2IlInjected.Address(RVA = "0x108DC20", Offset = "0x108DC20", VA = "0x108DC20", Slot = "17")]
		internal override void CustomizeButton(UIElement button)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005234")]
		[Cpp2IlInjected.Address(RVA = "0x108DCEC", Offset = "0x108DCEC", VA = "0x108DCEC", Slot = "18")]
		internal override string GetButtonTextKey()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6005235")]
		[Cpp2IlInjected.Address(RVA = "0x108DD3C", Offset = "0x108DD3C", VA = "0x108DD3C", Slot = "19")]
		public override bool GetIsUnlocked()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6005236")]
		[Cpp2IlInjected.Address(RVA = "0x108DD44", Offset = "0x108DD44", VA = "0x108DD44", Slot = "20")]
		public void Save(BinaryWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005237")]
		[Cpp2IlInjected.Address(RVA = "0x108DD60", Offset = "0x108DD60", VA = "0x108DD60", Slot = "21")]
		public void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005238")]
		[Cpp2IlInjected.Address(RVA = "0x108DD8C", Offset = "0x108DD8C", VA = "0x108DD8C", Slot = "22")]
		public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005239")]
		[Cpp2IlInjected.Address(RVA = "0x108DDA0", Offset = "0x108DDA0", VA = "0x108DDA0")]
		public StopBiomeSpreadPower()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A92")]
	public class SpawnRateSliderPerPlayerPower : APerPlayerSliderPower, IPersistentPerPlayerContent
	{
		[Cpp2IlInjected.Token(Token = "0x17000900")]
		public float StrengthMultiplierToGiveNPCs
		{
			[Cpp2IlInjected.Token(Token = "0x600523A")]
			[Cpp2IlInjected.Address(RVA = "0x108C888", Offset = "0x108C888", VA = "0x108C888")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600523B")]
			[Cpp2IlInjected.Address(RVA = "0x108C890", Offset = "0x108C890", VA = "0x108C890")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600523C")]
		[Cpp2IlInjected.Address(RVA = "0x108C898", Offset = "0x108C898", VA = "0x108C898")]
		public SpawnRateSliderPerPlayerPower()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600523D")]
		[Cpp2IlInjected.Address(RVA = "0x108C940", Offset = "0x108C940", VA = "0x108C940")]
		public bool GetShouldDisableSpawnsFor(int playerIndex)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600523E")]
		[Cpp2IlInjected.Address(RVA = "0x108CA44", Offset = "0x108CA44", VA = "0x108CA44", Slot = "19")]
		internal override void UpdateInfoFromSliderValueCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600523F")]
		[Cpp2IlInjected.Address(RVA = "0x108CA48", Offset = "0x108CA48", VA = "0x108CA48", Slot = "18")]
		public override float RemapSliderValueToPowerValue(float sliderValue)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6005240")]
		[Cpp2IlInjected.Address(RVA = "0x108CB58", Offset = "0x108CB58", VA = "0x108CB58", Slot = "20")]
		public override UIElement ProvideSlider()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6005241")]
		[Cpp2IlInjected.Address(RVA = "0x108D0DC", Offset = "0x108D0DC", VA = "0x108D0DC")]
		private void Button_OnMouseOut(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005242")]
		[Cpp2IlInjected.Address(RVA = "0x108D1CC", Offset = "0x108D1CC", VA = "0x108D1CC")]
		private void Button_OnMouseOver(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005243")]
		[Cpp2IlInjected.Address(RVA = "0x108D2BC", Offset = "0x108D2BC", VA = "0x108D2BC")]
		private void topText_OnClick(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005244")]
		[Cpp2IlInjected.Address(RVA = "0x108D300", Offset = "0x108D300", VA = "0x108D300")]
		private void middleText_OnClick(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005245")]
		[Cpp2IlInjected.Address(RVA = "0x108D344", Offset = "0x108D344", VA = "0x108D344")]
		private void bottomText_OnClick(UIMouseEvent evt, UIElement listeningElement)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005246")]
		[Cpp2IlInjected.Address(RVA = "0x108D384", Offset = "0x108D384", VA = "0x108D384")]
		private void UpdateSliderAndShowMultiplierMouseOver(UIElement affectedElement)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005247")]
		[Cpp2IlInjected.Address(RVA = "0x108D554", Offset = "0x108D554", VA = "0x108D554", Slot = "23")]
		public override bool GetIsUnlocked()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6005248")]
		[Cpp2IlInjected.Address(RVA = "0x108D55C", Offset = "0x108D55C", VA = "0x108D55C", Slot = "24")]
		public void Save(Player player, BinaryWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005249")]
		[Cpp2IlInjected.Address(RVA = "0x108D578", Offset = "0x108D578", VA = "0x108D578", Slot = "27")]
		public void ResetDataForNewPlayer(Player player)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600524A")]
		[Cpp2IlInjected.Address(RVA = "0x108D588", Offset = "0x108D588", VA = "0x108D588", Slot = "25")]
		public void Load(Player player, BinaryReader reader, int gameVersionSaveWasMadeOn)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600524B")]
		[Cpp2IlInjected.Address(RVA = "0x108D5B4", Offset = "0x108D5B4", VA = "0x108D5B4", Slot = "26")]
		public void ApplyLoadedDataToOutOfPlayerFields(Player player)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60041F4")]
	[Cpp2IlInjected.Address(RVA = "0x108445C", Offset = "0x108445C", VA = "0x108445C")]
	public CreativePowers()
	{
	}
}
