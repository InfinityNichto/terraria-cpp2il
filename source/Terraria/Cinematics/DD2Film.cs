using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.GameContent.UI;
using Terraria.Utilities;

namespace Terraria.Cinematics
{
	// Token: 0x02000525 RID: 1317
	[global::Cpp2ILInjected.Token(Token = "0x200078E")]
	public class DD2Film : Film
	{
		// Token: 0x06003890 RID: 14480 RVA: 0x0002C198 File Offset: 0x0002A398
		[global::Cpp2ILInjected.Token(Token = "0x6003F2F")]
		[global::Cpp2ILInjected.Address(RVA = "0x7438B8", Offset = "0x7438B8", Length = "0xB90")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Film), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FrameEvent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Film), Member = "AppendKeyFrames", MemberParameters = new object[] { typeof(FrameEvent[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Film), Member = "AppendSequences", MemberParameters = new object[]
		{
			typeof(int),
			typeof(FrameEvent[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Film), Member = "AddKeyFrame", MemberParameters = new object[]
		{
			typeof(int),
			typeof(FrameEvent)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Film), Member = "AddSequences", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(FrameEvent[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Film), Member = "AddSequence", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(FrameEvent)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 106)]
		public DD2Film()
		{
			throw null;
		}

		// Token: 0x06003891 RID: 14481 RVA: 0x0002C19B File Offset: 0x0002A39B
		[global::Cpp2ILInjected.Token(Token = "0x6003F30")]
		[global::Cpp2ILInjected.Address(RVA = "0x744B48", Offset = "0x744B48", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CombatText), Member = "clearAll", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void PerFrameSettings(FrameEventData evt)
		{
			throw null;
		}

		// Token: 0x06003892 RID: 14482 RVA: 0x0002C19E File Offset: 0x0002A39E
		[global::Cpp2ILInjected.Token(Token = "0x6003F31")]
		[global::Cpp2ILInjected.Address(RVA = "0x744B98", Offset = "0x744B98", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DD2Film), Member = "PlaceNPCOnGround", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Vector2)
		}, ReturnType = typeof(NPC))]
		private void CreateDryad(FrameEventData evt)
		{
			throw null;
		}

		// Token: 0x06003893 RID: 14483 RVA: 0x0002C1A1 File Offset: 0x0002A3A1
		[global::Cpp2ILInjected.Token(Token = "0x6003F32")]
		[global::Cpp2ILInjected.Address(RVA = "0x744D98", Offset = "0x744D98", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void DryadInteract(FrameEventData evt)
		{
			throw null;
		}

		// Token: 0x06003894 RID: 14484 RVA: 0x0002C1A4 File Offset: 0x0002A3A4
		[global::Cpp2ILInjected.Token(Token = "0x6003F33")]
		[global::Cpp2ILInjected.Address(RVA = "0x744DDC", Offset = "0x744DDC", Length = "0x1D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EntitySource_Film), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Bottom", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "NewNPC", MemberParameters = new object[]
		{
			typeof(IEntitySource),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void SpawnWitherBeast(FrameEventData evt)
		{
			throw null;
		}

		// Token: 0x06003895 RID: 14485 RVA: 0x0002C1A7 File Offset: 0x0002A3A7
		[global::Cpp2ILInjected.Token(Token = "0x6003F34")]
		[global::Cpp2ILInjected.Address(RVA = "0x744FB0", Offset = "0x744FB0", Length = "0x1D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EntitySource_Film), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Bottom", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "NewNPC", MemberParameters = new object[]
		{
			typeof(IEntitySource),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void SpawnJavalinThrower(FrameEventData evt)
		{
			throw null;
		}

		// Token: 0x06003896 RID: 14486 RVA: 0x0002C1AA File Offset: 0x0002A3AA
		[global::Cpp2ILInjected.Token(Token = "0x6003F35")]
		[global::Cpp2ILInjected.Address(RVA = "0x745184", Offset = "0x745184", Length = "0x1D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EntitySource_Film), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Bottom", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "NewNPC", MemberParameters = new object[]
		{
			typeof(IEntitySource),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void SpawnGoblin(FrameEventData evt)
		{
			throw null;
		}

		// Token: 0x06003897 RID: 14487 RVA: 0x0002C1AD File Offset: 0x0002A3AD
		[global::Cpp2ILInjected.Token(Token = "0x6003F36")]
		[global::Cpp2ILInjected.Address(RVA = "0x745358", Offset = "0x745358", Length = "0x478")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "SelectRandom", MemberTypeParameters = new object[] { typeof(short) }, MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			typeof(short[])
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloat", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DD2Film), Member = "PlaceNPCOnGround", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Vector2)
		}, ReturnType = typeof(NPC))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EntitySource_Film), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "NewNPC", MemberParameters = new object[]
		{
			typeof(IEntitySource),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		private void CreateCritters(FrameEventData evt)
		{
			throw null;
		}

		// Token: 0x06003898 RID: 14488 RVA: 0x0002C1B0 File Offset: 0x0002A3B0
		[global::Cpp2ILInjected.Token(Token = "0x6003F37")]
		[global::Cpp2ILInjected.Address(RVA = "0x7457D0", Offset = "0x7457D0", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(LegacySoundStyle),
			typeof(Vector2)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void OgreSwingSound(FrameEventData evt)
		{
			throw null;
		}

		// Token: 0x06003899 RID: 14489 RVA: 0x0002C1B3 File Offset: 0x0002A3B3
		[global::Cpp2ILInjected.Token(Token = "0x6003F38")]
		[global::Cpp2ILInjected.Address(RVA = "0x745840", Offset = "0x745840", Length = "0x1B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void DryadPortalKnock(FrameEventData evt)
		{
			throw null;
		}

		// Token: 0x0600389A RID: 14490 RVA: 0x0002C1B6 File Offset: 0x0002A3B6
		[global::Cpp2ILInjected.Token(Token = "0x6003F39")]
		[global::Cpp2ILInjected.Address(RVA = "0x745A1C", Offset = "0x745A1C", Length = "0x13C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private void RemoveEnemyDamage(FrameEventData evt)
		{
			throw null;
		}

		// Token: 0x0600389B RID: 14491 RVA: 0x0002C1B9 File Offset: 0x0002A3B9
		[global::Cpp2ILInjected.Token(Token = "0x6003F3A")]
		[global::Cpp2ILInjected.Address(RVA = "0x745B58", Offset = "0x745B58", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private void RestoreEnemyDamage(FrameEventData evt)
		{
			throw null;
		}

		// Token: 0x0600389C RID: 14492 RVA: 0x0002C1BC File Offset: 0x0002A3BC
		[global::Cpp2ILInjected.Token(Token = "0x6003F3B")]
		[global::Cpp2ILInjected.Address(RVA = "0x745C90", Offset = "0x745C90", Length = "0x3EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(LegacySoundStyle),
			typeof(Vector2)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Vector3),
			typeof(float)
		}, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "set_Opacity", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Right", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Size", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Length", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private void DryadPortalFade(FrameEventData evt)
		{
			throw null;
		}

		// Token: 0x0600389D RID: 14493 RVA: 0x0002C1BF File Offset: 0x0002A3BF
		[global::Cpp2ILInjected.Token(Token = "0x6003F3C")]
		[global::Cpp2ILInjected.Address(RVA = "0x74607C", Offset = "0x74607C", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DD2Film), Member = "PlaceNPCOnGround", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Vector2)
		}, ReturnType = typeof(NPC))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void CreatePortal(FrameEventData evt)
		{
			throw null;
		}

		// Token: 0x0600389E RID: 14494 RVA: 0x0002C1C2 File Offset: 0x0002A3C2
		[global::Cpp2ILInjected.Token(Token = "0x6003F3D")]
		[global::Cpp2ILInjected.Address(RVA = "0x746124", Offset = "0x746124", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void DryadStand(FrameEventData evt)
		{
			throw null;
		}

		// Token: 0x0600389F RID: 14495 RVA: 0x0002C1C5 File Offset: 0x0002A3C5
		[global::Cpp2ILInjected.Token(Token = "0x6003F3E")]
		[global::Cpp2ILInjected.Address(RVA = "0x746150", Offset = "0x746150", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void DryadLookRight(FrameEventData evt)
		{
			throw null;
		}

		// Token: 0x060038A0 RID: 14496 RVA: 0x0002C1C8 File Offset: 0x0002A3C8
		[global::Cpp2ILInjected.Token(Token = "0x6003F3F")]
		[global::Cpp2ILInjected.Address(RVA = "0x746168", Offset = "0x746168", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void DryadLookLeft(FrameEventData evt)
		{
			throw null;
		}

		// Token: 0x060038A1 RID: 14497 RVA: 0x0002C1CB File Offset: 0x0002A3CB
		[global::Cpp2ILInjected.Token(Token = "0x6003F40")]
		[global::Cpp2ILInjected.Address(RVA = "0x746180", Offset = "0x746180", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void DryadWalk(FrameEventData evt)
		{
			throw null;
		}

		// Token: 0x060038A2 RID: 14498 RVA: 0x0002C1CE File Offset: 0x0002A3CE
		[global::Cpp2ILInjected.Token(Token = "0x6003F41")]
		[global::Cpp2ILInjected.Address(RVA = "0x746198", Offset = "0x746198", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldUIAnchor), Member = ".ctor", MemberParameters = new object[] { typeof(Entity) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EmoteBubble), Member = "NewBubble", MemberParameters = new object[]
		{
			typeof(int),
			typeof(WorldUIAnchor),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void DryadConfusedEmote(FrameEventData evt)
		{
			throw null;
		}

		// Token: 0x060038A3 RID: 14499 RVA: 0x0002C1D1 File Offset: 0x0002A3D1
		[global::Cpp2ILInjected.Token(Token = "0x6003F42")]
		[global::Cpp2ILInjected.Address(RVA = "0x746258", Offset = "0x746258", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldUIAnchor), Member = ".ctor", MemberParameters = new object[] { typeof(Entity) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EmoteBubble), Member = "NewBubble", MemberParameters = new object[]
		{
			typeof(int),
			typeof(WorldUIAnchor),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void DryadAlertEmote(FrameEventData evt)
		{
			throw null;
		}

		// Token: 0x060038A4 RID: 14500 RVA: 0x0002C1D4 File Offset: 0x0002A3D4
		[global::Cpp2ILInjected.Token(Token = "0x6003F43")]
		[global::Cpp2ILInjected.Address(RVA = "0x746318", Offset = "0x746318", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EntitySource_Film), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Bottom", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "NewNPC", MemberParameters = new object[]
		{
			typeof(IEntitySource),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void CreateOgre(FrameEventData evt)
		{
			throw null;
		}

		// Token: 0x060038A5 RID: 14501 RVA: 0x0002C1D7 File Offset: 0x0002A3D7
		[global::Cpp2ILInjected.Token(Token = "0x6003F44")]
		[global::Cpp2ILInjected.Address(RVA = "0x746474", Offset = "0x746474", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void OgreStand(FrameEventData evt)
		{
			throw null;
		}

		// Token: 0x060038A6 RID: 14502 RVA: 0x0002C1DA File Offset: 0x0002A3DA
		[global::Cpp2ILInjected.Token(Token = "0x6003F45")]
		[global::Cpp2ILInjected.Address(RVA = "0x746514", Offset = "0x746514", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void DryadAttack(FrameEventData evt)
		{
			throw null;
		}

		// Token: 0x060038A7 RID: 14503 RVA: 0x0002C1DD File Offset: 0x0002A3DD
		[global::Cpp2ILInjected.Token(Token = "0x6003F46")]
		[global::Cpp2ILInjected.Address(RVA = "0x746548", Offset = "0x746548", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void OgreLookRight(FrameEventData evt)
		{
			throw null;
		}

		// Token: 0x060038A8 RID: 14504 RVA: 0x0002C1E0 File Offset: 0x0002A3E0
		[global::Cpp2ILInjected.Token(Token = "0x6003F47")]
		[global::Cpp2ILInjected.Address(RVA = "0x746560", Offset = "0x746560", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void OgreLookLeft(FrameEventData evt)
		{
			throw null;
		}

		// Token: 0x060038A9 RID: 14505 RVA: 0x0002C1E3 File Offset: 0x0002A3E3
		[global::Cpp2ILInjected.Token(Token = "0x6003F48")]
		[global::Cpp2ILInjected.Address(RVA = "0x746578", Offset = "0x746578", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "NewText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte),
			typeof(byte),
			typeof(byte)
		}, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override void OnBegin()
		{
			throw null;
		}

		// Token: 0x060038AA RID: 14506 RVA: 0x0002C1E6 File Offset: 0x0002A3E6
		[global::Cpp2ILInjected.Token(Token = "0x6003F49")]
		[global::Cpp2ILInjected.Address(RVA = "0x744BDC", Offset = "0x744BDC", Length = "0x1BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Film), Member = "CreateDryad", MemberParameters = new object[] { typeof(FrameEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Film), Member = "CreateCritters", MemberParameters = new object[] { typeof(FrameEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Film), Member = "CreatePortal", MemberParameters = new object[] { typeof(FrameEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "SolidTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EntitySource_Film), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "NewNPC", MemberParameters = new object[]
		{
			typeof(IEntitySource),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private NPC PlaceNPCOnGround(int type, Vector2 position)
		{
			throw null;
		}

		// Token: 0x060038AB RID: 14507 RVA: 0x0002C1E9 File Offset: 0x0002A3E9
		[global::Cpp2ILInjected.Token(Token = "0x6003F4A")]
		[global::Cpp2ILInjected.Address(RVA = "0x7466B4", Offset = "0x7466B4", Length = "0x25C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "NewText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte),
			typeof(byte),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public override void OnEnd()
		{
			throw null;
		}

		// Token: 0x0400687E RID: 26750
		[global::Cpp2ILInjected.Token(Token = "0x4007DA4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private NPC _dryad;

		// Token: 0x0400687F RID: 26751
		[global::Cpp2ILInjected.Token(Token = "0x4007DA5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private NPC _ogre;

		// Token: 0x04006880 RID: 26752
		[global::Cpp2ILInjected.Token(Token = "0x4007DA6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private NPC _portal;

		// Token: 0x04006881 RID: 26753
		[global::Cpp2ILInjected.Token(Token = "0x4007DA7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private List<NPC> _army;

		// Token: 0x04006882 RID: 26754
		[global::Cpp2ILInjected.Token(Token = "0x4007DA8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private List<NPC> _critters;

		// Token: 0x04006883 RID: 26755
		[global::Cpp2ILInjected.Token(Token = "0x4007DA9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private Vector2 _startPoint;
	}
}
