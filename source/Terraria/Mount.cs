using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.GameContent.Achievements;
using Terraria.GameContent.Drawing;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.Localization;
using Terraria.Utilities;

namespace Terraria
{
	// Token: 0x02000335 RID: 821
	[global::Cpp2ILInjected.Token(Token = "0x2000441")]
	public class Mount
	{
		// Token: 0x06002670 RID: 9840 RVA: 0x00028D87 File Offset: 0x00026F87
		[global::Cpp2ILInjected.Token(Token = "0x6002904")]
		[global::Cpp2ILInjected.Address(RVA = "0x10E7DE8", Offset = "0x10E7DE8", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		private static void MeowcartLandingSound(Player Player, Vector2 Position, int Width, int Height)
		{
			throw null;
		}

		// Token: 0x06002671 RID: 9841 RVA: 0x00028D8A File Offset: 0x00026F8A
		[global::Cpp2ILInjected.Token(Token = "0x6002905")]
		[global::Cpp2ILInjected.Address(RVA = "0x10E7E3C", Offset = "0x10E7E3C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		private static void MeowcartBumperSound(Player Player, Vector2 Position, int Width, int Height)
		{
			throw null;
		}

		// Token: 0x06002672 RID: 9842 RVA: 0x00028D8D File Offset: 0x00026F8D
		[global::Cpp2ILInjected.Token(Token = "0x6002906")]
		[global::Cpp2ILInjected.Address(RVA = "0x10E7E90", Offset = "0x10E7E90", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mount.MountDelegatesData), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<DrillDebugDraw>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public Mount()
		{
			throw null;
		}

		// Token: 0x06002673 RID: 9843 RVA: 0x00028D90 File Offset: 0x00026F90
		[global::Cpp2ILInjected.Token(Token = "0x6002907")]
		[global::Cpp2ILInjected.Address(RVA = "0x10E7F68", Offset = "0x10E7F68", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Reset()
		{
			throw null;
		}

		// Token: 0x06002674 RID: 9844 RVA: 0x00028D93 File Offset: 0x00026F93
		[global::Cpp2ILInjected.Token(Token = "0x6002908")]
		[global::Cpp2ILInjected.Address(RVA = "0x10E7F98", Offset = "0x10E7F98", Length = "0x4ADC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize_AlmostEverything", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "PostContentLoadInitialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mount.MountData), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LogicClient", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Width", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Height", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mount.MountDelegatesData), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<Vector2>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mount), Member = "SetAsMinecart", MemberParameters = new object[]
		{
			typeof(Mount.MountData),
			typeof(int),
			typeof(int),
			typeof(Asset<Texture2D>),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<object, Vector2, int, int>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mount), Member = "SetAsHorse", MemberParameters = new object[]
		{
			typeof(Mount.MountData),
			typeof(int),
			typeof(Asset<Texture2D>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mount.MountDelegatesData.OverridePositionMethod), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 371)]
		public static void Initialize()
		{
			throw null;
		}

		// Token: 0x06002675 RID: 9845 RVA: 0x00028D96 File Offset: 0x00026F96
		[global::Cpp2ILInjected.Token(Token = "0x6002909")]
		[global::Cpp2ILInjected.Address(RVA = "0x10ECCD8", Offset = "0x10ECCD8", Length = "0x238")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LogicClient", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Width", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Height", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private static void SetAsHorse(Mount.MountData newMount, int buff, Asset<Texture2D> texture)
		{
			throw null;
		}

		// Token: 0x06002676 RID: 9846 RVA: 0x00028D99 File Offset: 0x00026F99
		[global::Cpp2ILInjected.Token(Token = "0x600290A")]
		[global::Cpp2ILInjected.Address(RVA = "0x10ECA74", Offset = "0x10ECA74", Length = "0x264")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 23)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mount.MountDelegatesData), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<Vector2>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LogicClient", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Width", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Height", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private static void SetAsMinecart(Mount.MountData newMount, int buffToLeft, int buffToRight, Asset<Texture2D> texture, int verticalOffset = 0, int playerVerticalOffset = 0)
		{
			throw null;
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06002677 RID: 9847 RVA: 0x00028D9C File Offset: 0x00026F9C
		[global::Cpp2ILInjected.Token(Token = "0x170005A6")]
		public bool Active
		{
			[global::Cpp2ILInjected.Token(Token = "0x600290B")]
			[global::Cpp2ILInjected.Address(RVA = "0x10ECF10", Offset = "0x10ECF10", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06002678 RID: 9848 RVA: 0x00028D9F File Offset: 0x00026F9F
		[global::Cpp2ILInjected.Token(Token = "0x170005A7")]
		public int Type
		{
			[global::Cpp2ILInjected.Token(Token = "0x600290C")]
			[global::Cpp2ILInjected.Address(RVA = "0x10ECF18", Offset = "0x10ECF18", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06002679 RID: 9849 RVA: 0x00028DA2 File Offset: 0x00026FA2
		[global::Cpp2ILInjected.Token(Token = "0x170005A8")]
		public int FlyTime
		{
			[global::Cpp2ILInjected.Token(Token = "0x600290D")]
			[global::Cpp2ILInjected.Address(RVA = "0x10ECF20", Offset = "0x10ECF20", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x0600267A RID: 9850 RVA: 0x00028DA5 File Offset: 0x00026FA5
		[global::Cpp2ILInjected.Token(Token = "0x170005A9")]
		public int BuffType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600290E")]
			[global::Cpp2ILInjected.Address(RVA = "0x10ECF28", Offset = "0x10ECF28", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x0600267B RID: 9851 RVA: 0x00028DA8 File Offset: 0x00026FA8
		[global::Cpp2ILInjected.Token(Token = "0x170005AA")]
		public int BodyFrame
		{
			[global::Cpp2ILInjected.Token(Token = "0x600290F")]
			[global::Cpp2ILInjected.Address(RVA = "0x10ECF34", Offset = "0x10ECF34", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "PlayerFrame", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x0600267C RID: 9852 RVA: 0x00028DAB File Offset: 0x00026FAB
		[global::Cpp2ILInjected.Token(Token = "0x170005AB")]
		public int XOffset
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002910")]
			[global::Cpp2ILInjected.Address(RVA = "0x10ECF40", Offset = "0x10ECF40", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x0600267D RID: 9853 RVA: 0x00028DAE File Offset: 0x00026FAE
		[global::Cpp2ILInjected.Token(Token = "0x170005AC")]
		public int YOffset
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002911")]
			[global::Cpp2ILInjected.Address(RVA = "0x10ECF4C", Offset = "0x10ECF4C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x0600267E RID: 9854 RVA: 0x00028DB1 File Offset: 0x00026FB1
		[global::Cpp2ILInjected.Token(Token = "0x170005AD")]
		public int PlayerXOFfset
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002912")]
			[global::Cpp2ILInjected.Address(RVA = "0x10ECF58", Offset = "0x10ECF58", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "get_MountXOffset", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x0600267F RID: 9855 RVA: 0x00028DB4 File Offset: 0x00026FB4
		[global::Cpp2ILInjected.Token(Token = "0x170005AE")]
		public int PlayerOffset
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002913")]
			[global::Cpp2ILInjected.Address(RVA = "0x10ECF64", Offset = "0x10ECF64", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "get_HeightOffsetVisual", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "RotatedRelativePoint", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06002680 RID: 9856 RVA: 0x00028DB7 File Offset: 0x00026FB7
		[global::Cpp2ILInjected.Token(Token = "0x170005AF")]
		public int PlayerOffsetHitbox
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002914")]
			[global::Cpp2ILInjected.Address(RVA = "0x10ECF98", Offset = "0x10ECF98", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "GetPlayerArmPosition", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "get_HeightOffsetHitboxCenter", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06002681 RID: 9857 RVA: 0x00028DBA File Offset: 0x00026FBA
		[global::Cpp2ILInjected.Token(Token = "0x170005B0")]
		public int PlayerHeadOffset
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002915")]
			[global::Cpp2ILInjected.Address(RVA = "0x10ECFE0", Offset = "0x10ECFE0", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "get_HeightMapOffset", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06002682 RID: 9858 RVA: 0x00028DBD File Offset: 0x00026FBD
		[global::Cpp2ILInjected.Token(Token = "0x170005B1")]
		public int HeightBoost
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002916")]
			[global::Cpp2ILInjected.Address(RVA = "0x10ECFFC", Offset = "0x10ECFFC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "get_HeightOffsetBoost", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ResizeHitbox", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002683 RID: 9859 RVA: 0x00028DC0 File Offset: 0x00026FC0
		[global::Cpp2ILInjected.Token(Token = "0x6002917")]
		[global::Cpp2ILInjected.Address(RVA = "0x10ED008", Offset = "0x10ED008", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GrappleMovement", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static int GetHeightBoost(int MountType)
		{
			throw null;
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06002684 RID: 9860 RVA: 0x00028DC3 File Offset: 0x00026FC3
		[global::Cpp2ILInjected.Token(Token = "0x170005B2")]
		public float RunSpeed
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002918")]
			[global::Cpp2ILInjected.Address(RVA = "0x10ED0B4", Offset = "0x10ED0B4", Length = "0x16C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "HorizontalMovement", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "SetArmorEffectVisuals", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "UpdateFrame", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "UpdateEffects", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 22)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06002685 RID: 9861 RVA: 0x00028DC6 File Offset: 0x00026FC6
		[global::Cpp2ILInjected.Token(Token = "0x170005B3")]
		public float DashSpeed
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002919")]
			[global::Cpp2ILInjected.Address(RVA = "0x10ED220", Offset = "0x10ED220", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "HorizontalMovement", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "SetArmorEffectVisuals", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "UpdateFrame", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "UpdateEffects", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "Draw", MemberParameters = new object[]
			{
				typeof(ref PlayerDrawSet),
				typeof(int),
				typeof(Player),
				typeof(Vector2),
				typeof(Color),
				typeof(SpriteEffects),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06002686 RID: 9862 RVA: 0x00028DC9 File Offset: 0x00026FC9
		[global::Cpp2ILInjected.Token(Token = "0x170005B4")]
		public float Acceleration
		{
			[global::Cpp2ILInjected.Token(Token = "0x600291A")]
			[global::Cpp2ILInjected.Address(RVA = "0x10ED294", Offset = "0x10ED294", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06002687 RID: 9863 RVA: 0x00028DCC File Offset: 0x00026FCC
		[global::Cpp2ILInjected.Token(Token = "0x170005B5")]
		public float FallDamage
		{
			[global::Cpp2ILInjected.Token(Token = "0x600291B")]
			[global::Cpp2ILInjected.Address(RVA = "0x10ED308", Offset = "0x10ED308", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002688 RID: 9864 RVA: 0x00028DCF File Offset: 0x00026FCF
		[global::Cpp2ILInjected.Token(Token = "0x600291C")]
		[global::Cpp2ILInjected.Address(RVA = "0x10ED314", Offset = "0x10ED314", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "UpdateJumpHeight", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public int JumpHeight(float xVelocity)
		{
			throw null;
		}

		// Token: 0x06002689 RID: 9865 RVA: 0x00028DD2 File Offset: 0x00026FD2
		[global::Cpp2ILInjected.Token(Token = "0x600291D")]
		[global::Cpp2ILInjected.Address(RVA = "0x10ED43C", Offset = "0x10ED43C", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "UpdateJumpHeight", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public float JumpSpeed(float xVelocity)
		{
			throw null;
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x0600268A RID: 9866 RVA: 0x00028DD5 File Offset: 0x00026FD5
		[global::Cpp2ILInjected.Token(Token = "0x170005B6")]
		public bool AutoJump
		{
			[global::Cpp2ILInjected.Token(Token = "0x600291E")]
			[global::Cpp2ILInjected.Address(RVA = "0x10ED520", Offset = "0x10ED520", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x0600268B RID: 9867 RVA: 0x00028DD8 File Offset: 0x00026FD8
		[global::Cpp2ILInjected.Token(Token = "0x170005B7")]
		public bool BlockExtraJumps
		{
			[global::Cpp2ILInjected.Token(Token = "0x600291F")]
			[global::Cpp2ILInjected.Address(RVA = "0x10ED52C", Offset = "0x10ED52C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerMovementAccsCache), Member = "CopyFrom", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x0600268C RID: 9868 RVA: 0x00028DDB File Offset: 0x00026FDB
		[global::Cpp2ILInjected.Token(Token = "0x170005B8")]
		public bool IsConsideredASlimeMount
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002920")]
			[global::Cpp2ILInjected.Address(RVA = "0x10ED538", Offset = "0x10ED538", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ApplyEquipVanity", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Item)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "get_SlimeDontHyperJump", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "JumpMovement", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "PlayerFrame", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x0600268D RID: 9869 RVA: 0x00028DDE File Offset: 0x00026FDE
		[global::Cpp2ILInjected.Token(Token = "0x170005B9")]
		public bool Cart
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002921")]
			[global::Cpp2ILInjected.Address(RVA = "0x10ED554", Offset = "0x10ED554", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIQuickActionButton), Member = "Draw", MemberParameters = new object[]
			{
				typeof(QuickActionButton_Layout.QuickActionControl),
				typeof(QuickActionButton_Layout),
				typeof(bool),
				typeof(ref float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIQuickActionButton), Member = "CanMount", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(Item)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Yoraiz0rEye", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "UpdateEquips", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "HorizontalMovement", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "JumpMovement", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "DryCollision", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "FloorVisuals", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetHurtTile", ReturnType = typeof(Collision.HurtTile))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "TileInteractionsUse", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Hurt", MemberParameters = new object[]
			{
				typeof(PlayerDeathReason),
				typeof(int),
				typeof(int),
				typeof(bool),
				typeof(bool),
				typeof(bool),
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(double))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawSet), Member = "BoringSetup", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(DrawData[]),
				typeof(List<int>),
				typeof(List<int>),
				typeof(Vector2),
				typeof(float),
				typeof(float),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_25_Shield", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 32)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x0600268E RID: 9870 RVA: 0x00028DE1 File Offset: 0x00026FE1
		[global::Cpp2ILInjected.Token(Token = "0x170005BA")]
		public bool Directional
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002922")]
			[global::Cpp2ILInjected.Address(RVA = "0x10ED57C", Offset = "0x10ED57C", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x0600268F RID: 9871 RVA: 0x00028DE4 File Offset: 0x00026FE4
		[global::Cpp2ILInjected.Token(Token = "0x170005BB")]
		public Mount.MountDelegatesData Delegations
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002923")]
			[global::Cpp2ILInjected.Address(RVA = "0x10ED59C", Offset = "0x10ED59C", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "HorizontalMovement", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GrappleMovement", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "get_MouthPosition", ReturnType = typeof(Vector2?))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "get_HandPosition", ReturnType = typeof(Vector2?))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06002690 RID: 9872 RVA: 0x00028DE7 File Offset: 0x00026FE7
		[global::Cpp2ILInjected.Token(Token = "0x170005BC")]
		public Vector2 Origin
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002924")]
			[global::Cpp2ILInjected.Address(RVA = "0x10ED5B8", Offset = "0x10ED5B8", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "Draw", MemberParameters = new object[]
			{
				typeof(ref PlayerDrawSet),
				typeof(int),
				typeof(Player),
				typeof(Vector2),
				typeof(Color),
				typeof(SpriteEffects),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002691 RID: 9873 RVA: 0x00028DEA File Offset: 0x00026FEA
		[global::Cpp2ILInjected.Token(Token = "0x6002925")]
		[global::Cpp2ILInjected.Address(RVA = "0x10ED600", Offset = "0x10ED600", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "HorizontalMovement", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_026", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		public bool CanFly()
		{
			throw null;
		}

		// Token: 0x06002692 RID: 9874 RVA: 0x00028DED File Offset: 0x00026FED
		[global::Cpp2ILInjected.Token(Token = "0x6002926")]
		[global::Cpp2ILInjected.Address(RVA = "0x10ED62C", Offset = "0x10ED62C", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "PlayerFrame", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public bool CanHover()
		{
			throw null;
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06002693 RID: 9875 RVA: 0x00028DF0 File Offset: 0x00026FF0
		[global::Cpp2ILInjected.Token(Token = "0x170005BD")]
		public bool AbilityCharging
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002927")]
			[global::Cpp2ILInjected.Address(RVA = "0x10ED66C", Offset = "0x10ED66C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06002694 RID: 9876 RVA: 0x00028DF3 File Offset: 0x00026FF3
		[global::Cpp2ILInjected.Token(Token = "0x170005BE")]
		public bool AbilityActive
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002928")]
			[global::Cpp2ILInjected.Address(RVA = "0x10ED674", Offset = "0x10ED674", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06002695 RID: 9877 RVA: 0x00028DF6 File Offset: 0x00026FF6
		[global::Cpp2ILInjected.Token(Token = "0x170005BF")]
		public float AbilityCharge
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002929")]
			[global::Cpp2ILInjected.Address(RVA = "0x10ED67C", Offset = "0x10ED67C", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002696 RID: 9878 RVA: 0x00028DF9 File Offset: 0x00026FF9
		[global::Cpp2ILInjected.Token(Token = "0x600292A")]
		[global::Cpp2ILInjected.Address(RVA = "0x10ED698", Offset = "0x10ED698", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "StartAbilityCharge", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "UseAbility", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(Vector2),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "CastSuperCartLaser", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EntitySource_Mount), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Entity),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public IEntitySource GetProjectileSpawnSource(Player mountedPlayer)
		{
			throw null;
		}

		// Token: 0x06002697 RID: 9879 RVA: 0x00028DFC File Offset: 0x00026FFC
		[global::Cpp2ILInjected.Token(Token = "0x600292B")]
		[global::Cpp2ILInjected.Address(RVA = "0x10ED708", Offset = "0x10ED708", Length = "0x168")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseX", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseY", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mount), Member = "GetProjectileSpawnSource", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(IEntitySource))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Projectile), Member = "NewProjectile", MemberParameters = new object[]
		{
			typeof(IEntitySource),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void StartAbilityCharge(Player mountedPlayer)
		{
			throw null;
		}

		// Token: 0x06002698 RID: 9880 RVA: 0x00028DFF File Offset: 0x00026FFF
		[global::Cpp2ILInjected.Token(Token = "0x600292C")]
		[global::Cpp2ILInjected.Address(RVA = "0x10ED870", Offset = "0x10ED870", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "Kill", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void StopAbilityCharge()
		{
			throw null;
		}

		// Token: 0x06002699 RID: 9881 RVA: 0x00028E02 File Offset: 0x00027002
		[global::Cpp2ILInjected.Token(Token = "0x600292D")]
		[global::Cpp2ILInjected.Address(RVA = "0x10ED89C", Offset = "0x10ED89C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBuffs), Member = "RemoveBuff", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "TryRemovingBuff", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public bool CheckBuff(int buffID)
		{
			throw null;
		}

		// Token: 0x0600269A RID: 9882 RVA: 0x00028E05 File Offset: 0x00027005
		[global::Cpp2ILInjected.Token(Token = "0x600292E")]
		[global::Cpp2ILInjected.Address(RVA = "0x10ED8C4", Offset = "0x10ED8C4", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void AbilityRecovery()
		{
			throw null;
		}

		// Token: 0x0600269B RID: 9883 RVA: 0x00028E08 File Offset: 0x00027008
		[global::Cpp2ILInjected.Token(Token = "0x600292F")]
		[global::Cpp2ILInjected.Address(RVA = "0x10ED918", Offset = "0x10ED918", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void FatigueRecovery()
		{
			throw null;
		}

		// Token: 0x0600269C RID: 9884 RVA: 0x00028E0B File Offset: 0x0002700B
		[global::Cpp2ILInjected.Token(Token = "0x6002930")]
		[global::Cpp2ILInjected.Address(RVA = "0x10ED93C", Offset = "0x10ED93C", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public bool Flight()
		{
			throw null;
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x0600269D RID: 9885 RVA: 0x00028E0E File Offset: 0x0002700E
		[global::Cpp2ILInjected.Token(Token = "0x170005C0")]
		public bool AllowDirectionChange
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002931")]
			[global::Cpp2ILInjected.Address(RVA = "0x10ED95C", Offset = "0x10ED95C", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "HorizontalMovement", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600269E RID: 9886 RVA: 0x00028E11 File Offset: 0x00027011
		[global::Cpp2ILInjected.Token(Token = "0x6002932")]
		[global::Cpp2ILInjected.Address(RVA = "0x10ED990", Offset = "0x10ED990", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void UpdateDrill(Player mountedPlayer, bool controlUp, bool controlDown)
		{
			throw null;
		}

		// Token: 0x0600269F RID: 9887 RVA: 0x00028E14 File Offset: 0x00027014
		[global::Cpp2ILInjected.Token(Token = "0x6002933")]
		[global::Cpp2ILInjected.Address(RVA = "0x10EDAD0", Offset = "0x10EDAD0", Length = "0x990")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mount), Member = "DrillSmartCursor_Blocks", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(Mount.DrillMountData)
		}, ReturnType = typeof(Point16))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point16), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Point16),
			typeof(Point16)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "InWorld", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "PickTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDeathReason), Member = "ByOther", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(PlayerDeathReason))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "Hurt", MemberParameters = new object[]
		{
			typeof(PlayerDeathReason),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotation", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "NextDouble", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDust", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "SmoothSlope", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mount), Member = "DrillSmartCursor_Walls", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(Mount.DrillMountData)
		}, ReturnType = typeof(Point16))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "PickWall", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 42)]
		public void UseDrill(Player mountedPlayer)
		{
			throw null;
		}

		// Token: 0x060026A0 RID: 9888 RVA: 0x00028E17 File Offset: 0x00027017
		[global::Cpp2ILInjected.Token(Token = "0x6002934")]
		[global::Cpp2ILInjected.Address(RVA = "0x10EE9FC", Offset = "0x10EE9FC", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "CanKillTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "nactive", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static bool DrillSmartCursor_BlocksPlot(int x, int y)
		{
			throw null;
		}

		// Token: 0x060026A1 RID: 9889 RVA: 0x00028E1A File Offset: 0x0002701A
		[global::Cpp2ILInjected.Token(Token = "0x6002935")]
		[global::Cpp2ILInjected.Address(RVA = "0x10EE460", Offset = "0x10EE460", Length = "0x2A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "UseDrill", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseX", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseY", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Length", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Normalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "PlotTileLine", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(float),
			typeof(Utils.TileActionAttempt)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point16), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private Point16 DrillSmartCursor_Blocks(Player mountedPlayer, Mount.DrillMountData data)
		{
			throw null;
		}

		// Token: 0x060026A2 RID: 9890 RVA: 0x00028E1D File Offset: 0x0002701D
		[global::Cpp2ILInjected.Token(Token = "0x6002936")]
		[global::Cpp2ILInjected.Address(RVA = "0x10EE708", Offset = "0x10EE708", Length = "0x2F4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "UseDrill", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mount.<>c__DisplayClass141_0), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseX", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseY", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Length", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Normalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point16), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils.TileActionAttempt), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "PlotTileLine", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(float),
			typeof(Utils.TileActionAttempt)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private Point16 DrillSmartCursor_Walls(Player mountedPlayer, Mount.DrillMountData data)
		{
			throw null;
		}

		// Token: 0x060026A3 RID: 9891 RVA: 0x00028E20 File Offset: 0x00027020
		[global::Cpp2ILInjected.Token(Token = "0x6002937")]
		[global::Cpp2ILInjected.Address(RVA = "0x10EEB58", Offset = "0x10EEB58", Length = "0x80C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheck_HandleMount", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "Kill", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "UpdateEffects", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mount), Member = "ClampToDeadZone", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Normalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mount), Member = "GetProjectileSpawnSource", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(IEntitySource))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Projectile), Member = "NewProjectile", MemberParameters = new object[]
		{
			typeof(IEntitySource),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseX", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseY", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "RotatedByRandom", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(double)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LegacySoundStyle), Member = "get_Style", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "SafeNormalize", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		public void UseAbility(Player mountedPlayer, Vector2 mousePosition, bool toggleOn)
		{
			throw null;
		}

		// Token: 0x060026A4 RID: 9892 RVA: 0x00028E23 File Offset: 0x00027023
		[global::Cpp2ILInjected.Token(Token = "0x6002938")]
		[global::Cpp2ILInjected.Address(RVA = "0x10EF5D8", Offset = "0x10EF5D8", Length = "0x760")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collision), Member = "TileCollision", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_MountFishronSpecial", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "AddLight", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public bool Hover(Player mountedPlayer)
		{
			throw null;
		}

		// Token: 0x060026A5 RID: 9893 RVA: 0x00028E26 File Offset: 0x00027026
		[global::Cpp2ILInjected.Token(Token = "0x6002939")]
		[global::Cpp2ILInjected.Address(RVA = "0x10EFD38", Offset = "0x10EFD38", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool DoesHoverIgnoresFatigue()
		{
			throw null;
		}

		// Token: 0x060026A6 RID: 9894 RVA: 0x00028E29 File Offset: 0x00027029
		[global::Cpp2ILInjected.Token(Token = "0x600293A")]
		[global::Cpp2ILInjected.Address(RVA = "0x10EFD7C", Offset = "0x10EFD7C", Length = "0x290")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "UpdateEffects", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "Draw", MemberParameters = new object[]
		{
			typeof(ref PlayerDrawSet),
			typeof(int),
			typeof(Player),
			typeof(Vector2),
			typeof(Color),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "Clamp", MemberTypeParameters = new object[] { typeof(float) }, MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToTileCoordinates", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "InAPlaceWithWind", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private float GetWitchBroomTrinketRotation(Player player)
		{
			throw null;
		}

		// Token: 0x060026A7 RID: 9895 RVA: 0x00028E2C File Offset: 0x0002702C
		[global::Cpp2ILInjected.Token(Token = "0x600293B")]
		[global::Cpp2ILInjected.Address(RVA = "0x10F000C", Offset = "0x10F000C", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		private Vector2 GetWitchBroomTrinketOriginOffset(Player player)
		{
			throw null;
		}

		// Token: 0x060026A8 RID: 9896 RVA: 0x00028E2F File Offset: 0x0002702F
		[global::Cpp2ILInjected.Token(Token = "0x600293C")]
		[global::Cpp2ILInjected.Address(RVA = "0x10F0040", Offset = "0x10F0040", Length = "0x2CB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "PlayerFrame", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "TryLanding", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToTileCoordinates", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "AddLight", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mount), Member = "get_DashSpeed", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mount), Member = "get_RunSpeed", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "SelectRandom", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			typeof(int[])
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Sign", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "GetLerpValue", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "Clamp", MemberTypeParameters = new object[] { typeof(float) }, MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mount), Member = "UpdateFrame_GolfCart", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(int),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collision), Member = "GetTileRotation", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Length", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloat", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDust", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "RotatedBy", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(double),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArmorShaderDataSet), Member = "GetSecondaryShader", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Player)
		}, ReturnType = typeof(ArmorShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_liquid", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "SolidTileAllowBottomSlope", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleOrchestrator), Member = "RequestParticleSpawn", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(ParticleOrchestraType),
			typeof(ParticleOrchestraSettings),
			typeof(int?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "AddLight", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_BottomLeft", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "FloorVisuals", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Bottom", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "SelectRandom", MemberTypeParameters = new object[] { typeof(short) }, MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			typeof(short[])
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 175)]
		public void UpdateFrame(Player mountedPlayer, int state, Vector2 velocity)
		{
			throw null;
		}

		// Token: 0x060026A9 RID: 9897 RVA: 0x00028E32 File Offset: 0x00027032
		[global::Cpp2ILInjected.Token(Token = "0x600293D")]
		[global::Cpp2ILInjected.Address(RVA = "0x10F2FBC", Offset = "0x10F2FBC", Length = "0x234")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "PlayerFrame", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collision), Member = "TileCollision", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void TryBeginningFlight(Player mountedPlayer, int state)
		{
			throw null;
		}

		// Token: 0x060026AA RID: 9898 RVA: 0x00028E35 File Offset: 0x00027035
		[global::Cpp2ILInjected.Token(Token = "0x600293E")]
		[global::Cpp2ILInjected.Address(RVA = "0x10F31F0", Offset = "0x10F31F0", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "PlayerFrame", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public int GetIntendedGroundedFrame(Player mountedPlayer)
		{
			throw null;
		}

		// Token: 0x060026AB RID: 9899 RVA: 0x00028E38 File Offset: 0x00027038
		[global::Cpp2ILInjected.Token(Token = "0x600293F")]
		[global::Cpp2ILInjected.Address(RVA = "0x10F3234", Offset = "0x10F3234", Length = "0x1D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "PlayerFrame", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collision), Member = "TileCollision", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mount), Member = "UpdateFrame", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(int),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void TryLanding(Player mountedPlayer)
		{
			throw null;
		}

		// Token: 0x060026AC RID: 9900 RVA: 0x00028E3B File Offset: 0x0002703B
		[global::Cpp2ILInjected.Token(Token = "0x6002940")]
		[global::Cpp2ILInjected.Address(RVA = "0x10F2CF4", Offset = "0x10F2CF4", Length = "0x2C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "UpdateFrame", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(int),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Bottom", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mount), Member = "EmitGolfCartWheelDust", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mount), Member = "EmitGolfCartlight", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void UpdateFrame_GolfCart(Player mountedPlayer, int state, Vector2 velocity)
		{
			throw null;
		}

		// Token: 0x060026AD RID: 9901 RVA: 0x00028E3E File Offset: 0x0002703E
		[global::Cpp2ILInjected.Token(Token = "0x6002941")]
		[global::Cpp2ILInjected.Address(RVA = "0x10F3910", Offset = "0x10F3910", Length = "0x250")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Bottom", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDustDirect", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Dust))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Sign", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static void EmitGolfCartSmoke(Player mountedPlayer, bool rushing)
		{
			throw null;
		}

		// Token: 0x060026AE RID: 9902 RVA: 0x00028E41 File Offset: 0x00027041
		[global::Cpp2ILInjected.Token(Token = "0x6002942")]
		[global::Cpp2ILInjected.Address(RVA = "0x10F36C4", Offset = "0x10F36C4", Length = "0x24C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "UpdateFrame_GolfCart", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(int),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToTileCoordinates", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToVector2", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotationVector2", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils.TileActionAttempt), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "PlotTileLine", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(float),
			typeof(Utils.TileActionAttempt)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private static void EmitGolfCartlight(Vector2 worldLocation, int playerDirection)
		{
			throw null;
		}

		// Token: 0x060026AF RID: 9903 RVA: 0x00028E44 File Offset: 0x00027044
		[global::Cpp2ILInjected.Token(Token = "0x6002943")]
		[global::Cpp2ILInjected.Address(RVA = "0x10F3B60", Offset = "0x10F3B60", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool ShouldGolfCartEmitLight()
		{
			throw null;
		}

		// Token: 0x060026B0 RID: 9904 RVA: 0x00028E47 File Offset: 0x00027047
		[global::Cpp2ILInjected.Token(Token = "0x6002944")]
		[global::Cpp2ILInjected.Address(RVA = "0x10F340C", Offset = "0x10F340C", Length = "0x2B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "UpdateFrame_GolfCart", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(int),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToTileCoordinates", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "InWorld", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Framing), Member = "GetTileSafely", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "SolidTile", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "KillTile_GetTileDustAmount", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(Tile)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "KillTile_MakeTileDust", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Tile)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private static void EmitGolfCartWheelDust(Player mountedPlayer, Vector2 legSpot)
		{
			throw null;
		}

		// Token: 0x060026B1 RID: 9905 RVA: 0x00028E4A File Offset: 0x0002704A
		[global::Cpp2ILInjected.Token(Token = "0x6002945")]
		[global::Cpp2ILInjected.Address(RVA = "0x10F3B68", Offset = "0x10F3B68", Length = "0x2A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "UpdateEffects", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextVector2Square", MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_Directions", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "RotatedRelativePoint", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDustPerfect", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(Vector2?),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Dust))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArmorShaderDataSet), Member = "GetSecondaryShader", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Player)
		}, ReturnType = typeof(ArmorShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private void DoGemMinecartEffect(Player mountedPlayer, int dustType)
		{
			throw null;
		}

		// Token: 0x060026B2 RID: 9906 RVA: 0x00028E4D File Offset: 0x0002704D
		[global::Cpp2ILInjected.Token(Token = "0x6002946")]
		[global::Cpp2ILInjected.Address(RVA = "0x10F3E08", Offset = "0x10F3E08", Length = "0x2CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "UpdateEffects", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextVector2Square", MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_Directions", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "RotatedRelativePoint", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDustPerfect", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(Vector2?),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Dust))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArmorShaderDataSet), Member = "GetSecondaryShader", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Player)
		}, ReturnType = typeof(ArmorShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private void DoSteamMinecartEffect(Player mountedPlayer, int dustType)
		{
			throw null;
		}

		// Token: 0x060026B3 RID: 9907 RVA: 0x00028E50 File Offset: 0x00027050
		[global::Cpp2ILInjected.Token(Token = "0x6002947")]
		[global::Cpp2ILInjected.Address(RVA = "0x10F40D4", Offset = "0x10F40D4", Length = "0x400")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "UpdateEffects", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Length", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextVector2Square", MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_Directions", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "RotatedRelativePoint", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDustPerfect", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(Vector2?),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Dust))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArmorShaderDataSet), Member = "GetSecondaryShader", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Player)
		}, ReturnType = typeof(ArmorShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private void DoExhaustMinecartEffect(Player mountedPlayer, int dustType)
		{
			throw null;
		}

		// Token: 0x060026B4 RID: 9908 RVA: 0x00028E53 File Offset: 0x00027053
		[global::Cpp2ILInjected.Token(Token = "0x6002948")]
		[global::Cpp2ILInjected.Address(RVA = "0x10F44D4", Offset = "0x10F44D4", Length = "0x4A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "UpdateEffects", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Length", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloat", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextVector2Square", MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_Directions", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "RotatedRelativePoint", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDustPerfect", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(Vector2?),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Dust))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArmorShaderDataSet), Member = "GetSecondaryShader", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Player)
		}, ReturnType = typeof(ArmorShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		private void DoConfettiMinecartEffect(Player mountedPlayer)
		{
			throw null;
		}

		// Token: 0x060026B5 RID: 9909 RVA: 0x00028E56 File Offset: 0x00027056
		[global::Cpp2ILInjected.Token(Token = "0x6002949")]
		[global::Cpp2ILInjected.Address(RVA = "0x10F4978", Offset = "0x10F4978", Length = "0x2018")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_UsingSuperCart", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mount), Member = "CastSuperCartLaser", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mount), Member = "get_RunSpeed", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mount), Member = "get_DashSpeed", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementsHelper), Member = "HandleSpecialEvent", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Sign", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LogicClient", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(float)
		}, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "AddLight", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Top", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Bottom", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Left", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Right", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "RotatedBy", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(double),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Size", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Distance", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDust", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArmorShaderDataSet), Member = "GetSecondaryShader", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Player)
		}, ReturnType = typeof(ArmorShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_MountFishronSpecial", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Colors), Member = "get_CurrentLiquidColor", ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "ToVector3", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToTileCoordinates", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "SolidTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_Directions", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "RotatedRelativePoint", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Length", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloat", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextVector2Circular", MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2?), Member = ".ctor", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDustPerfect", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(Vector2?),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Dust))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mount), Member = "GetWitchBroomTrinketRotation", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotationVector2", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "AddLight", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "DirectionTo", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_MountedCenter", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "PlotTileLine", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(float),
			typeof(Utils.TileActionAttempt)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mount), Member = "DoGemMinecartEffect", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mount), Member = "DoExhaustMinecartEffect", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mount), Member = "DoConfettiMinecartEffect", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mount), Member = "DoSteamMinecartEffect", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "CanBeChasedBy", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotation", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collision), Member = "CanHitLine", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mount), Member = "AimAbility", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mount), Member = "UseAbility", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(Vector2),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "AddLight", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "InAPlaceWithWind", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 116)]
		public void UpdateEffects(Player mountedPlayer)
		{
			throw null;
		}

		// Token: 0x060026B6 RID: 9910 RVA: 0x00028E59 File Offset: 0x00027059
		[global::Cpp2ILInjected.Token(Token = "0x600294A")]
		[global::Cpp2ILInjected.Address(RVA = "0x10F6990", Offset = "0x10F6990", Length = "0x4BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "UpdateEffects", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Sign", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mount), Member = "GetMinecartMechPoint", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "Distance", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "CanBeChasedBy", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collision), Member = "CanHitLine", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "AngleFrom", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "WrapAngle", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Size", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "RandomVector2", MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotation", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mount), Member = "GetProjectileSpawnSource", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(IEntitySource))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Projectile), Member = "NewProjectile", MemberParameters = new object[]
		{
			typeof(IEntitySource),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "set_Center", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Projectile), Member = "Damage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		private void CastSuperCartLaser(Player mountedPlayer)
		{
			throw null;
		}

		// Token: 0x060026B7 RID: 9911 RVA: 0x00028E5C File Offset: 0x0002705C
		[global::Cpp2ILInjected.Token(Token = "0x600294B")]
		[global::Cpp2ILInjected.Address(RVA = "0x10F7598", Offset = "0x10F7598", Length = "0x2A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "CastSuperCartLaser", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Sign", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Sign", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "RotatedBy", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(double),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Bottom", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static Vector2 GetMinecartMechPoint(Player mountedPlayer, int offX, int offY)
		{
			throw null;
		}

		// Token: 0x060026B8 RID: 9912 RVA: 0x00028E5F File Offset: 0x0002705F
		[global::Cpp2ILInjected.Token(Token = "0x600294C")]
		[global::Cpp2ILInjected.Address(RVA = "0x10F7840", Offset = "0x10F7840", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void ResetFlightTime(float xVelocity)
		{
			throw null;
		}

		// Token: 0x060026B9 RID: 9913 RVA: 0x00028E62 File Offset: 0x00027062
		[global::Cpp2ILInjected.Token(Token = "0x600294D")]
		[global::Cpp2ILInjected.Address(RVA = "0x10F78EC", Offset = "0x10F78EC", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ResetEffects", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void CheckMountBuff(Player mountedPlayer)
		{
			throw null;
		}

		// Token: 0x060026BA RID: 9914 RVA: 0x00028E65 File Offset: 0x00027065
		[global::Cpp2ILInjected.Token(Token = "0x600294E")]
		[global::Cpp2ILInjected.Address(RVA = "0x10F7574", Offset = "0x10F7574", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void ResetHeadPosition()
		{
			throw null;
		}

		// Token: 0x060026BB RID: 9915 RVA: 0x00028E68 File Offset: 0x00027068
		[global::Cpp2ILInjected.Token(Token = "0x600294F")]
		[global::Cpp2ILInjected.Address(RVA = "0x10EF364", Offset = "0x10EF364", Length = "0x274")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "UseAbility", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(Vector2),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "AimAbility", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private Vector2 ClampToDeadZone(Player mountedPlayer, Vector2 position)
		{
			throw null;
		}

		// Token: 0x060026BC RID: 9916 RVA: 0x00028E6B File Offset: 0x0002706B
		[global::Cpp2ILInjected.Token(Token = "0x6002950")]
		[global::Cpp2ILInjected.Address(RVA = "0x10F6E4C", Offset = "0x10F6E4C", Length = "0x728")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "UpdateEffects", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mount), Member = "ClampToDeadZone", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotation", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "ToDegrees", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "AddLight", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public bool AimAbility(Player mountedPlayer, Vector2 mousePosition)
		{
			throw null;
		}

		// Token: 0x060026BD RID: 9917 RVA: 0x00028E6E File Offset: 0x0002706E
		[global::Cpp2ILInjected.Token(Token = "0x6002951")]
		[global::Cpp2ILInjected.Address(RVA = "0x10F7C28", Offset = "0x10F7C28", Length = "0x1C9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_02_MountBehindPlayer", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_23_MountFront", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ARenderTargetContentByRequest), Member = "Request", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "Clamp", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "ToVector4", ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector4), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector4),
			typeof(float)
		}, ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector4), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector4), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector4),
			typeof(Vector4)
		}, ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[] { typeof(Vector4) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Colors), Member = "get_CurrentLiquidColor", ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mount), Member = "get_Origin", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Sign", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrawData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawSet), Member = "AddDrawData", MemberParameters = new object[] { typeof(ref DrawData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDrawHelper), Member = "PackShader", MemberParameters = new object[]
		{
			typeof(int),
			typeof(PlayerDrawHelper.ShaderConfiguration)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "RotatedBy", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(double),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point16), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Point16),
			typeof(Point16)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotation", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Length", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrawData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mount), Member = "get_DashSpeed", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mount), Member = "GetWitchBroomTrinketRotation", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Floor", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotationVector2", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 88)]
		public void Draw(ref PlayerDrawSet playerDrawData, int drawType, Player drawPlayer, Vector2 Position, Color drawColor, SpriteEffects playerEffect, float shadow)
		{
			throw null;
		}

		// Token: 0x060026BE RID: 9918 RVA: 0x00028E71 File Offset: 0x00027071
		[global::Cpp2ILInjected.Token(Token = "0x6002952")]
		[global::Cpp2ILInjected.Address(RVA = "0x10F79C8", Offset = "0x10F79C8", Length = "0x260")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBuffs), Member = "RemoveBuff", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "TryRemovingBuff", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "QuickMount", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "QuickGrapple", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GrappleMovement", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "TileInteractionsUse", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "PetAnimal", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Hurt", MemberParameters = new object[]
		{
			typeof(PlayerDeathReason),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "KillMe", MemberParameters = new object[]
		{
			typeof(PlayerDeathReason),
			typeof(double),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheck_HandleMount", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerSittingHelper), Member = "SitDown", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerSleepingHelper), Member = "StartSleeping", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "ClearBuff", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mount), Member = "DoSpawnDust", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(NetworkText),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public void Dismount(Player mountedPlayer)
		{
			throw null;
		}

		// Token: 0x060026BF RID: 9919 RVA: 0x00028E74 File Offset: 0x00027074
		[global::Cpp2ILInjected.Token(Token = "0x6002953")]
		[global::Cpp2ILInjected.Address(RVA = "0x10FA560", Offset = "0x10FA560", Length = "0x4E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "QuickMount", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "UpdateBuffs", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GrappleMovement", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheck", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "ClearBuff", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "AddBuff", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "ResetAdvancedShadows", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mount.DrillMountData), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mount.ExtraFrameMountData), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mount), Member = "DoSpawnDust", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(NetworkText),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public void SetMount(int m, Player mountedPlayer, bool faceLeft = false)
		{
			throw null;
		}

		// Token: 0x060026C0 RID: 9920 RVA: 0x00028E77 File Offset: 0x00027077
		[global::Cpp2ILInjected.Token(Token = "0x6002954")]
		[global::Cpp2ILInjected.Address(RVA = "0x10F98C4", Offset = "0x10F98C4", Length = "0xC9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "Dismount", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "SetMount", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Player),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHostOnly", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDustDirect", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Dust))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloat", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloatDirection", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "CloneDust", MemberParameters = new object[] { typeof(Dust) }, ReturnType = typeof(Dust))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Gore), Member = "NewGore", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "NextDouble", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Matrix), Member = "CreateRotationZ", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(Matrix))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Transform", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Matrix)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDust", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 65)]
		private void DoSpawnDust(Player mountedPlayer, bool isDismounting)
		{
			throw null;
		}

		// Token: 0x060026C1 RID: 9921 RVA: 0x00028E7A File Offset: 0x0002707A
		[global::Cpp2ILInjected.Token(Token = "0x6002955")]
		[global::Cpp2ILInjected.Address(RVA = "0x10FAA48", Offset = "0x10FAA48", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "QuickMount", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheck", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "CanFitSpace", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool CanMount(int m, Player mountingPlayer)
		{
			throw null;
		}

		// Token: 0x060026C2 RID: 9922 RVA: 0x00028E7D File Offset: 0x0002707D
		[global::Cpp2ILInjected.Token(Token = "0x6002956")]
		[global::Cpp2ILInjected.Address(RVA = "0x10FAAC4", Offset = "0x10FAAC4", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool FindTileHeight(Vector2 position, int maxTilesDown, out float tileHeight)
		{
			throw null;
		}

		// Token: 0x060026C3 RID: 9923 RVA: 0x00028E80 File Offset: 0x00027080
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6002957")]
		[global::Cpp2ILInjected.Address(RVA = "0x10FABE4", Offset = "0x10FABE4", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils.TileActionAttempt), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static Mount()
		{
			throw null;
		}

		// Token: 0x04002E72 RID: 11890
		[global::Cpp2ILInjected.Token(Token = "0x40035E3")]
		public static int currentShader;

		// Token: 0x04002E73 RID: 11891
		[global::Cpp2ILInjected.Token(Token = "0x40035E4")]
		public const int FrameStanding = 0;

		// Token: 0x04002E74 RID: 11892
		[global::Cpp2ILInjected.Token(Token = "0x40035E5")]
		public const int FrameRunning = 1;

		// Token: 0x04002E75 RID: 11893
		[global::Cpp2ILInjected.Token(Token = "0x40035E6")]
		public const int FrameInAir = 2;

		// Token: 0x04002E76 RID: 11894
		[global::Cpp2ILInjected.Token(Token = "0x40035E7")]
		public const int FrameFlying = 3;

		// Token: 0x04002E77 RID: 11895
		[global::Cpp2ILInjected.Token(Token = "0x40035E8")]
		public const int FrameSwimming = 4;

		// Token: 0x04002E78 RID: 11896
		[global::Cpp2ILInjected.Token(Token = "0x40035E9")]
		public const int FrameDashing = 5;

		// Token: 0x04002E79 RID: 11897
		[global::Cpp2ILInjected.Token(Token = "0x40035EA")]
		public const int DrawBack = 0;

		// Token: 0x04002E7A RID: 11898
		[global::Cpp2ILInjected.Token(Token = "0x40035EB")]
		public const int DrawBackExtra = 1;

		// Token: 0x04002E7B RID: 11899
		[global::Cpp2ILInjected.Token(Token = "0x40035EC")]
		public const int DrawFront = 2;

		// Token: 0x04002E7C RID: 11900
		[global::Cpp2ILInjected.Token(Token = "0x40035ED")]
		public const int DrawFrontExtra = 3;

		// Token: 0x04002E7D RID: 11901
		[global::Cpp2ILInjected.Token(Token = "0x40035EE")]
		private static Mount.MountData[] mounts;

		// Token: 0x04002E7E RID: 11902
		[global::Cpp2ILInjected.Token(Token = "0x40035EF")]
		private static Vector2[] scutlixEyePositions;

		// Token: 0x04002E7F RID: 11903
		[global::Cpp2ILInjected.Token(Token = "0x40035F0")]
		private static Vector2 scutlixTextureSize;

		// Token: 0x04002E80 RID: 11904
		[global::Cpp2ILInjected.Token(Token = "0x40035F1")]
		public const int scutlixBaseDamage = 50;

		// Token: 0x04002E81 RID: 11905
		[global::Cpp2ILInjected.Token(Token = "0x40035F2")]
		public static Vector2 drillDiodePoint1;

		// Token: 0x04002E82 RID: 11906
		[global::Cpp2ILInjected.Token(Token = "0x40035F3")]
		public static Vector2 drillDiodePoint2;

		// Token: 0x04002E83 RID: 11907
		[global::Cpp2ILInjected.Token(Token = "0x40035F4")]
		public static Vector2 drillTextureSize;

		// Token: 0x04002E84 RID: 11908
		[global::Cpp2ILInjected.Token(Token = "0x40035F5")]
		public const int drillTextureWidth = 80;

		// Token: 0x04002E85 RID: 11909
		[global::Cpp2ILInjected.Token(Token = "0x40035F6")]
		public const float drillRotationChange = 0.05235988f;

		// Token: 0x04002E86 RID: 11910
		[global::Cpp2ILInjected.Token(Token = "0x40035F7")]
		public static int drillPickPower;

		// Token: 0x04002E87 RID: 11911
		[global::Cpp2ILInjected.Token(Token = "0x40035F8")]
		public static int drillPickTime;

		// Token: 0x04002E88 RID: 11912
		[global::Cpp2ILInjected.Token(Token = "0x40035F9")]
		public static int amountOfBeamsAtOnce;

		// Token: 0x04002E89 RID: 11913
		[global::Cpp2ILInjected.Token(Token = "0x40035FA")]
		public const float maxDrillLength = 48f;

		// Token: 0x04002E8A RID: 11914
		[global::Cpp2ILInjected.Token(Token = "0x40035FB")]
		private static Vector2 santankTextureSize;

		// Token: 0x04002E8B RID: 11915
		[global::Cpp2ILInjected.Token(Token = "0x40035FC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Mount.MountData _data;

		// Token: 0x04002E8C RID: 11916
		[global::Cpp2ILInjected.Token(Token = "0x40035FD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int _type;

		// Token: 0x04002E8D RID: 11917
		[global::Cpp2ILInjected.Token(Token = "0x40035FE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private bool _flipDraw;

		// Token: 0x04002E8E RID: 11918
		[global::Cpp2ILInjected.Token(Token = "0x40035FF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int _frame;

		// Token: 0x04002E8F RID: 11919
		[global::Cpp2ILInjected.Token(Token = "0x4003600")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private float _frameCounter;

		// Token: 0x04002E90 RID: 11920
		[global::Cpp2ILInjected.Token(Token = "0x4003601")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private int _frameExtra;

		// Token: 0x04002E91 RID: 11921
		[global::Cpp2ILInjected.Token(Token = "0x4003602")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private float _frameExtraCounter;

		// Token: 0x04002E92 RID: 11922
		[global::Cpp2ILInjected.Token(Token = "0x4003603")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int _frameState;

		// Token: 0x04002E93 RID: 11923
		[global::Cpp2ILInjected.Token(Token = "0x4003604")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private int _flyTime;

		// Token: 0x04002E94 RID: 11924
		[global::Cpp2ILInjected.Token(Token = "0x4003605")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private int _idleTime;

		// Token: 0x04002E95 RID: 11925
		[global::Cpp2ILInjected.Token(Token = "0x4003606")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		private int _idleTimeNext;

		// Token: 0x04002E96 RID: 11926
		[global::Cpp2ILInjected.Token(Token = "0x4003607")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private float _fatigue;

		// Token: 0x04002E97 RID: 11927
		[global::Cpp2ILInjected.Token(Token = "0x4003608")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		private float _fatigueMax;

		// Token: 0x04002E98 RID: 11928
		[global::Cpp2ILInjected.Token(Token = "0x4003609")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private bool _abilityCharging;

		// Token: 0x04002E99 RID: 11929
		[global::Cpp2ILInjected.Token(Token = "0x400360A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		private int _abilityCharge;

		// Token: 0x04002E9A RID: 11930
		[global::Cpp2ILInjected.Token(Token = "0x400360B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private int _abilityCooldown;

		// Token: 0x04002E9B RID: 11931
		[global::Cpp2ILInjected.Token(Token = "0x400360C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		private int _abilityDuration;

		// Token: 0x04002E9C RID: 11932
		[global::Cpp2ILInjected.Token(Token = "0x400360D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private bool _abilityActive;

		// Token: 0x04002E9D RID: 11933
		[global::Cpp2ILInjected.Token(Token = "0x400360E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x59")]
		private bool _aiming;

		// Token: 0x04002E9E RID: 11934
		[global::Cpp2ILInjected.Token(Token = "0x400360F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5A")]
		private bool _shouldSuperCart;

		// Token: 0x04002E9F RID: 11935
		[global::Cpp2ILInjected.Token(Token = "0x4003610")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		public List<DrillDebugDraw> _debugDraw;

		// Token: 0x04002EA0 RID: 11936
		[global::Cpp2ILInjected.Token(Token = "0x4003611")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private object _mountSpecificData;

		// Token: 0x04002EA1 RID: 11937
		[global::Cpp2ILInjected.Token(Token = "0x4003612")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private bool _active;

		// Token: 0x04002EA2 RID: 11938
		[global::Cpp2ILInjected.Token(Token = "0x4003613")]
		public static float SuperCartRunSpeed;

		// Token: 0x04002EA3 RID: 11939
		[global::Cpp2ILInjected.Token(Token = "0x4003614")]
		public static float SuperCartDashSpeed;

		// Token: 0x04002EA4 RID: 11940
		[global::Cpp2ILInjected.Token(Token = "0x4003615")]
		public static float SuperCartAcceleration;

		// Token: 0x04002EA5 RID: 11941
		[global::Cpp2ILInjected.Token(Token = "0x4003616")]
		public static int SuperCartJumpHeight;

		// Token: 0x04002EA6 RID: 11942
		[global::Cpp2ILInjected.Token(Token = "0x4003617")]
		public static float SuperCartJumpSpeed;

		// Token: 0x04002EA7 RID: 11943
		[global::Cpp2ILInjected.Token(Token = "0x4003618")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private Mount.MountDelegatesData _defaultDelegatesData;

		// Token: 0x04002EA8 RID: 11944
		[global::Cpp2ILInjected.Token(Token = "0x4003619")]
		private static Mount.DrillMountData DrillSmartCursor_BlocksPlotData;

		// Token: 0x04002EA9 RID: 11945
		[global::Cpp2ILInjected.Token(Token = "0x400361A")]
		private static int DrillSmartCursor_BlocksPlotX;

		// Token: 0x04002EAA RID: 11946
		[global::Cpp2ILInjected.Token(Token = "0x400361B")]
		private static int DrillSmartCursor_BlocksPlotY;

		// Token: 0x04002EAB RID: 11947
		[global::Cpp2ILInjected.Token(Token = "0x400361C")]
		private static Utils.TileActionAttempt DrillSmartCursor_BlocksPlotInstance;

		// Token: 0x02000866 RID: 2150
		[global::Cpp2ILInjected.Token(Token = "0x2000442")]
		private class DrillBeam
		{
			// Token: 0x06004A5F RID: 19039 RVA: 0x0002F2EE File Offset: 0x0002D4EE
			[global::Cpp2ILInjected.Token(Token = "0x6002958")]
			[global::Cpp2ILInjected.Address(RVA = "0x115A5C4", Offset = "0x115A5C4", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Mount.DrillMountData", Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public DrillBeam()
			{
				throw null;
			}

			// Token: 0x04007F27 RID: 32551
			[global::Cpp2ILInjected.Token(Token = "0x400361D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public Point16 curTileTarget;

			// Token: 0x04007F28 RID: 32552
			[global::Cpp2ILInjected.Token(Token = "0x400361E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			public int cooldown;

			// Token: 0x04007F29 RID: 32553
			[global::Cpp2ILInjected.Token(Token = "0x400361F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public int lastPurpose;
		}

		// Token: 0x02000867 RID: 2151
		[global::Cpp2ILInjected.Token(Token = "0x2000443")]
		private class DrillMountData
		{
			// Token: 0x06004A60 RID: 19040 RVA: 0x0002F2F1 File Offset: 0x0002D4F1
			[global::Cpp2ILInjected.Token(Token = "0x6002959")]
			[global::Cpp2ILInjected.Address(RVA = "0x115A634", Offset = "0x115A634", Length = "0xDC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "SetMount", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Player),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Terraria.Mount.DrillBeam", Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			public DrillMountData()
			{
				throw null;
			}

			// Token: 0x04007F2A RID: 32554
			[global::Cpp2ILInjected.Token(Token = "0x4003620")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public float diodeRotationTarget;

			// Token: 0x04007F2B RID: 32555
			[global::Cpp2ILInjected.Token(Token = "0x4003621")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			public float diodeRotation;

			// Token: 0x04007F2C RID: 32556
			[global::Cpp2ILInjected.Token(Token = "0x4003622")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public float outerRingRotation;

			// Token: 0x04007F2D RID: 32557
			[global::Cpp2ILInjected.Token(Token = "0x4003623")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public Mount.DrillBeam[] beams;

			// Token: 0x04007F2E RID: 32558
			[global::Cpp2ILInjected.Token(Token = "0x4003624")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public int beamCooldown;

			// Token: 0x04007F2F RID: 32559
			[global::Cpp2ILInjected.Token(Token = "0x4003625")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
			public Vector2 crosshairPosition;
		}

		// Token: 0x02000868 RID: 2152
		[global::Cpp2ILInjected.Token(Token = "0x2000444")]
		private class BooleanMountData
		{
			// Token: 0x06004A61 RID: 19041 RVA: 0x0002F2F4 File Offset: 0x0002D4F4
			[global::Cpp2ILInjected.Token(Token = "0x600295A")]
			[global::Cpp2ILInjected.Address(RVA = "0x115A710", Offset = "0x115A710", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public BooleanMountData()
			{
				throw null;
			}

			// Token: 0x04007F30 RID: 32560
			[global::Cpp2ILInjected.Token(Token = "0x4003626")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public bool boolean;
		}

		// Token: 0x02000869 RID: 2153
		[global::Cpp2ILInjected.Token(Token = "0x2000445")]
		private class ExtraFrameMountData
		{
			// Token: 0x06004A62 RID: 19042 RVA: 0x0002F2F7 File Offset: 0x0002D4F7
			[global::Cpp2ILInjected.Token(Token = "0x600295B")]
			[global::Cpp2ILInjected.Address(RVA = "0x115A72C", Offset = "0x115A72C", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "SetMount", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Player),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ExtraFrameMountData()
			{
				throw null;
			}

			// Token: 0x04007F31 RID: 32561
			[global::Cpp2ILInjected.Token(Token = "0x4003627")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public int frame;

			// Token: 0x04007F32 RID: 32562
			[global::Cpp2ILInjected.Token(Token = "0x4003628")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			public float frameCounter;
		}

		// Token: 0x0200086A RID: 2154
		[global::Cpp2ILInjected.Token(Token = "0x2000446")]
		public class MountDelegatesData
		{
			// Token: 0x06004A63 RID: 19043 RVA: 0x0002F2FA File Offset: 0x0002D4FA
			[global::Cpp2ILInjected.Token(Token = "0x600295C")]
			[global::Cpp2ILInjected.Address(RVA = "0x115A748", Offset = "0x115A748", Length = "0x148")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Mount.MountData", Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "SetAsMinecart", MemberParameters = new object[]
			{
				"Terraria.Mount.MountData",
				typeof(int),
				typeof(int),
				typeof(Asset<Texture2D>),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<Vector2>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<object, Vector2, int, int>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
			public MountDelegatesData()
			{
				throw null;
			}

			// Token: 0x04007F33 RID: 32563
			[global::Cpp2ILInjected.Token(Token = "0x4003629")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public Action<Vector2> MinecartDust;

			// Token: 0x04007F34 RID: 32564
			[global::Cpp2ILInjected.Token(Token = "0x400362A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public Action<Player, Vector2, int, int> MinecartJumpingSound;

			// Token: 0x04007F35 RID: 32565
			[global::Cpp2ILInjected.Token(Token = "0x400362B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public Action<Player, Vector2, int, int> MinecartLandingSound;

			// Token: 0x04007F36 RID: 32566
			[global::Cpp2ILInjected.Token(Token = "0x400362C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public Action<Player, Vector2, int, int> MinecartBumperSound;

			// Token: 0x04007F37 RID: 32567
			[global::Cpp2ILInjected.Token(Token = "0x400362D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public Mount.MountDelegatesData.OverridePositionMethod MouthPosition;

			// Token: 0x04007F38 RID: 32568
			[global::Cpp2ILInjected.Token(Token = "0x400362E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public Mount.MountDelegatesData.OverridePositionMethod HandPosition;

			// Token: 0x02000B5C RID: 2908
			// (Invoke) Token: 0x06005328 RID: 21288
			[global::Cpp2ILInjected.Token(Token = "0x2000447")]
			public delegate bool OverridePositionMethod(Player player, out Vector2? position);
		}

		// Token: 0x0200086B RID: 2155
		[global::Cpp2ILInjected.Token(Token = "0x2000448")]
		private class MountData
		{
			// Token: 0x06004A64 RID: 19044 RVA: 0x0002F2FD File Offset: 0x0002D4FD
			[global::Cpp2ILInjected.Token(Token = "0x6002961")]
			[global::Cpp2ILInjected.Address(RVA = "0x115AA8C", Offset = "0x115AA8C", Length = "0x10C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 54)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mount.MountDelegatesData), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			public MountData()
			{
				throw null;
			}

			// Token: 0x04007F39 RID: 32569
			[global::Cpp2ILInjected.Token(Token = "0x400362F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public Asset<Texture2D> backTexture;

			// Token: 0x04007F3A RID: 32570
			[global::Cpp2ILInjected.Token(Token = "0x4003630")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public Asset<Texture2D> backTextureGlow;

			// Token: 0x04007F3B RID: 32571
			[global::Cpp2ILInjected.Token(Token = "0x4003631")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public Asset<Texture2D> backTextureExtra;

			// Token: 0x04007F3C RID: 32572
			[global::Cpp2ILInjected.Token(Token = "0x4003632")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public Asset<Texture2D> backTextureExtraGlow;

			// Token: 0x04007F3D RID: 32573
			[global::Cpp2ILInjected.Token(Token = "0x4003633")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public Asset<Texture2D> frontTexture;

			// Token: 0x04007F3E RID: 32574
			[global::Cpp2ILInjected.Token(Token = "0x4003634")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public Asset<Texture2D> frontTextureGlow;

			// Token: 0x04007F3F RID: 32575
			[global::Cpp2ILInjected.Token(Token = "0x4003635")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			public Asset<Texture2D> frontTextureExtra;

			// Token: 0x04007F40 RID: 32576
			[global::Cpp2ILInjected.Token(Token = "0x4003636")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			public Asset<Texture2D> frontTextureExtraGlow;

			// Token: 0x04007F41 RID: 32577
			[global::Cpp2ILInjected.Token(Token = "0x4003637")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			public int textureWidth;

			// Token: 0x04007F42 RID: 32578
			[global::Cpp2ILInjected.Token(Token = "0x4003638")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
			public int textureHeight;

			// Token: 0x04007F43 RID: 32579
			[global::Cpp2ILInjected.Token(Token = "0x4003639")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			public int xOffset;

			// Token: 0x04007F44 RID: 32580
			[global::Cpp2ILInjected.Token(Token = "0x400363A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
			public int yOffset;

			// Token: 0x04007F45 RID: 32581
			[global::Cpp2ILInjected.Token(Token = "0x400363B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
			public int[] playerYOffsets;

			// Token: 0x04007F46 RID: 32582
			[global::Cpp2ILInjected.Token(Token = "0x400363C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
			public int bodyFrame;

			// Token: 0x04007F47 RID: 32583
			[global::Cpp2ILInjected.Token(Token = "0x400363D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
			public int playerHeadOffset;

			// Token: 0x04007F48 RID: 32584
			[global::Cpp2ILInjected.Token(Token = "0x400363E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
			public int heightBoost;

			// Token: 0x04007F49 RID: 32585
			[global::Cpp2ILInjected.Token(Token = "0x400363F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x74")]
			public int buff;

			// Token: 0x04007F4A RID: 32586
			[global::Cpp2ILInjected.Token(Token = "0x4003640")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
			public int extraBuff;

			// Token: 0x04007F4B RID: 32587
			[global::Cpp2ILInjected.Token(Token = "0x4003641")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
			public int flightTimeMax;

			// Token: 0x04007F4C RID: 32588
			[global::Cpp2ILInjected.Token(Token = "0x4003642")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
			public bool usesHover;

			// Token: 0x04007F4D RID: 32589
			[global::Cpp2ILInjected.Token(Token = "0x4003643")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x84")]
			public float runSpeed;

			// Token: 0x04007F4E RID: 32590
			[global::Cpp2ILInjected.Token(Token = "0x4003644")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
			public float dashSpeed;

			// Token: 0x04007F4F RID: 32591
			[global::Cpp2ILInjected.Token(Token = "0x4003645")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
			public float swimSpeed;

			// Token: 0x04007F50 RID: 32592
			[global::Cpp2ILInjected.Token(Token = "0x4003646")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
			public float acceleration;

			// Token: 0x04007F51 RID: 32593
			[global::Cpp2ILInjected.Token(Token = "0x4003647")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x94")]
			public float jumpSpeed;

			// Token: 0x04007F52 RID: 32594
			[global::Cpp2ILInjected.Token(Token = "0x4003648")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
			public int jumpHeight;

			// Token: 0x04007F53 RID: 32595
			[global::Cpp2ILInjected.Token(Token = "0x4003649")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x9C")]
			public float fallDamage;

			// Token: 0x04007F54 RID: 32596
			[global::Cpp2ILInjected.Token(Token = "0x400364A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
			public int fatigueMax;

			// Token: 0x04007F55 RID: 32597
			[global::Cpp2ILInjected.Token(Token = "0x400364B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xA4")]
			public bool constantJump;

			// Token: 0x04007F56 RID: 32598
			[global::Cpp2ILInjected.Token(Token = "0x400364C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xA5")]
			public bool blockExtraJumps;

			// Token: 0x04007F57 RID: 32599
			[global::Cpp2ILInjected.Token(Token = "0x400364D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
			public int abilityChargeMax;

			// Token: 0x04007F58 RID: 32600
			[global::Cpp2ILInjected.Token(Token = "0x400364E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xAC")]
			public int abilityDuration;

			// Token: 0x04007F59 RID: 32601
			[global::Cpp2ILInjected.Token(Token = "0x400364F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
			public int abilityCooldown;

			// Token: 0x04007F5A RID: 32602
			[global::Cpp2ILInjected.Token(Token = "0x4003650")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xB4")]
			public int spawnDust;

			// Token: 0x04007F5B RID: 32603
			[global::Cpp2ILInjected.Token(Token = "0x4003651")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
			public bool spawnDustNoGravity;

			// Token: 0x04007F5C RID: 32604
			[global::Cpp2ILInjected.Token(Token = "0x4003652")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xBC")]
			public int totalFrames;

			// Token: 0x04007F5D RID: 32605
			[global::Cpp2ILInjected.Token(Token = "0x4003653")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
			public int standingFrameStart;

			// Token: 0x04007F5E RID: 32606
			[global::Cpp2ILInjected.Token(Token = "0x4003654")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC4")]
			public int standingFrameCount;

			// Token: 0x04007F5F RID: 32607
			[global::Cpp2ILInjected.Token(Token = "0x4003655")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
			public int standingFrameDelay;

			// Token: 0x04007F60 RID: 32608
			[global::Cpp2ILInjected.Token(Token = "0x4003656")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xCC")]
			public int runningFrameStart;

			// Token: 0x04007F61 RID: 32609
			[global::Cpp2ILInjected.Token(Token = "0x4003657")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
			public int runningFrameCount;

			// Token: 0x04007F62 RID: 32610
			[global::Cpp2ILInjected.Token(Token = "0x4003658")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xD4")]
			public int runningFrameDelay;

			// Token: 0x04007F63 RID: 32611
			[global::Cpp2ILInjected.Token(Token = "0x4003659")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
			public int flyingFrameStart;

			// Token: 0x04007F64 RID: 32612
			[global::Cpp2ILInjected.Token(Token = "0x400365A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xDC")]
			public int flyingFrameCount;

			// Token: 0x04007F65 RID: 32613
			[global::Cpp2ILInjected.Token(Token = "0x400365B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
			public int flyingFrameDelay;

			// Token: 0x04007F66 RID: 32614
			[global::Cpp2ILInjected.Token(Token = "0x400365C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xE4")]
			public int inAirFrameStart;

			// Token: 0x04007F67 RID: 32615
			[global::Cpp2ILInjected.Token(Token = "0x400365D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
			public int inAirFrameCount;

			// Token: 0x04007F68 RID: 32616
			[global::Cpp2ILInjected.Token(Token = "0x400365E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xEC")]
			public int inAirFrameDelay;

			// Token: 0x04007F69 RID: 32617
			[global::Cpp2ILInjected.Token(Token = "0x400365F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
			public int idleFrameStart;

			// Token: 0x04007F6A RID: 32618
			[global::Cpp2ILInjected.Token(Token = "0x4003660")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xF4")]
			public int idleFrameCount;

			// Token: 0x04007F6B RID: 32619
			[global::Cpp2ILInjected.Token(Token = "0x4003661")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
			public int idleFrameDelay;

			// Token: 0x04007F6C RID: 32620
			[global::Cpp2ILInjected.Token(Token = "0x4003662")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xFC")]
			public bool idleFrameLoop;

			// Token: 0x04007F6D RID: 32621
			[global::Cpp2ILInjected.Token(Token = "0x4003663")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
			public int swimFrameStart;

			// Token: 0x04007F6E RID: 32622
			[global::Cpp2ILInjected.Token(Token = "0x4003664")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x104")]
			public int swimFrameCount;

			// Token: 0x04007F6F RID: 32623
			[global::Cpp2ILInjected.Token(Token = "0x4003665")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
			public int swimFrameDelay;

			// Token: 0x04007F70 RID: 32624
			[global::Cpp2ILInjected.Token(Token = "0x4003666")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10C")]
			public int dashingFrameStart;

			// Token: 0x04007F71 RID: 32625
			[global::Cpp2ILInjected.Token(Token = "0x4003667")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
			public int dashingFrameCount;

			// Token: 0x04007F72 RID: 32626
			[global::Cpp2ILInjected.Token(Token = "0x4003668")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x114")]
			public int dashingFrameDelay;

			// Token: 0x04007F73 RID: 32627
			[global::Cpp2ILInjected.Token(Token = "0x4003669")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
			public bool Minecart;

			// Token: 0x04007F74 RID: 32628
			[global::Cpp2ILInjected.Token(Token = "0x400366A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x119")]
			public bool MinecartDirectional;

			// Token: 0x04007F75 RID: 32629
			[global::Cpp2ILInjected.Token(Token = "0x400366B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x11C")]
			public Vector3 lightColor;

			// Token: 0x04007F76 RID: 32630
			[global::Cpp2ILInjected.Token(Token = "0x400366C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
			public bool emitsLight;

			// Token: 0x04007F77 RID: 32631
			[global::Cpp2ILInjected.Token(Token = "0x400366D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
			public Mount.MountDelegatesData delegations;

			// Token: 0x04007F78 RID: 32632
			[global::Cpp2ILInjected.Token(Token = "0x400366E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
			public int playerXOffset;
		}

		// Token: 0x0200086C RID: 2156
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000449")]
		private sealed class <>c__DisplayClass141_0
		{
			// Token: 0x06004A65 RID: 19045 RVA: 0x0002F300 File Offset: 0x0002D500
			[global::Cpp2ILInjected.Token(Token = "0x6002962")]
			[global::Cpp2ILInjected.Address(RVA = "0x115AB98", Offset = "0x115AB98", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "DrillSmartCursor_Walls", MemberParameters = new object[]
			{
				typeof(Player),
				"Terraria.Mount.DrillMountData"
			}, ReturnType = typeof(Point16))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass141_0()
			{
				throw null;
			}

			// Token: 0x06004A66 RID: 19046 RVA: 0x0002F303 File Offset: 0x0002D503
			[global::Cpp2ILInjected.Token(Token = "0x6002963")]
			[global::Cpp2ILInjected.Address(RVA = "0x115ABA0", Offset = "0x115ABA0", Length = "0x1B0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point16), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point16), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Point16),
				typeof(Point16)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Tile))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_wall", ReturnType = typeof(ushort))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "CanPlayerSmashWall", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			internal bool <DrillSmartCursor_Walls>b__0(int x, int y)
			{
				throw null;
			}

			// Token: 0x04007F79 RID: 32633
			[global::Cpp2ILInjected.Token(Token = "0x400366F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public Point16 tilePoint;

			// Token: 0x04007F7A RID: 32634
			[global::Cpp2ILInjected.Token(Token = "0x4003670")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public Mount.DrillMountData data;
		}
	}
}
