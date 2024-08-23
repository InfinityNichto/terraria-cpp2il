using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace Terraria.Cinematics
{
	// Token: 0x02000526 RID: 1318
	[global::Cpp2ILInjected.Token(Token = "0x200078F")]
	public class DSTFilm : Film
	{
		// Token: 0x060038AC RID: 14508 RVA: 0x0002C1EC File Offset: 0x0002A3EC
		[global::Cpp2ILInjected.Token(Token = "0x6003F4B")]
		[global::Cpp2ILInjected.Address(RVA = "0x746918", Offset = "0x746918", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Film), Member = ".ctor", ReturnType = typeof(void))]
		public DSTFilm()
		{
			throw null;
		}

		// Token: 0x060038AD RID: 14509 RVA: 0x0002C1EF File Offset: 0x0002A3EF
		[global::Cpp2ILInjected.Token(Token = "0x6003F4C")]
		[global::Cpp2ILInjected.Address(RVA = "0x746CE4", Offset = "0x746CE4", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DSTFilm), Member = "PrepareScene", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void OnBegin()
		{
			throw null;
		}

		// Token: 0x060038AE RID: 14510 RVA: 0x0002C1F2 File Offset: 0x0002A3F2
		[global::Cpp2ILInjected.Token(Token = "0x6003F4D")]
		[global::Cpp2ILInjected.Address(RVA = "0x746EC4", Offset = "0x746EC4", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DSTFilm), Member = "ClearScene", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void OnEnd()
		{
			throw null;
		}

		// Token: 0x060038AF RID: 14511 RVA: 0x0002C1F5 File Offset: 0x0002A3F5
		[global::Cpp2ILInjected.Token(Token = "0x6003F4E")]
		[global::Cpp2ILInjected.Address(RVA = "0x746930", Offset = "0x746930", Length = "0x3B4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FrameEvent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Film), Member = "AppendKeyFrames", MemberParameters = new object[] { typeof(FrameEvent[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Film), Member = "AppendEmptySequence", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 34)]
		private void BuildSequence()
		{
			throw null;
		}

		// Token: 0x060038B0 RID: 14512 RVA: 0x0002C1F8 File Offset: 0x0002A3F8
		[global::Cpp2ILInjected.Token(Token = "0x6003F4F")]
		[global::Cpp2ILInjected.Address(RVA = "0x746D50", Offset = "0x746D50", Length = "0x174")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DSTFilm), Member = "OnBegin", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToWorldCoordinates", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void PrepareScene()
		{
			throw null;
		}

		// Token: 0x060038B1 RID: 14513 RVA: 0x0002C1FB File Offset: 0x0002A3FB
		[global::Cpp2ILInjected.Token(Token = "0x6003F50")]
		[global::Cpp2ILInjected.Address(RVA = "0x746F2C", Offset = "0x746F2C", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DSTFilm), Member = "OnEnd", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void ClearScene()
		{
			throw null;
		}

		// Token: 0x060038B2 RID: 14514 RVA: 0x0002C1FE File Offset: 0x0002A3FE
		[global::Cpp2ILInjected.Token(Token = "0x6003F51")]
		[global::Cpp2ILInjected.Address(RVA = "0x74702C", Offset = "0x74702C", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void EquipDSTShaderItem(FrameEventData evt)
		{
			throw null;
		}

		// Token: 0x060038B3 RID: 14515 RVA: 0x0002C201 File Offset: 0x0002A401
		[global::Cpp2ILInjected.Token(Token = "0x6003F52")]
		[global::Cpp2ILInjected.Address(RVA = "0x7470FC", Offset = "0x7470FC", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void RemoveDSTShaderItem(FrameEventData evt)
		{
			throw null;
		}

		// Token: 0x060038B4 RID: 14516 RVA: 0x0002C204 File Offset: 0x0002A404
		[global::Cpp2ILInjected.Token(Token = "0x6003F53")]
		[global::Cpp2ILInjected.Address(RVA = "0x747184", Offset = "0x747184", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DSTFilm), Member = "PlaceNPCOnGround", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Vector2)
		}, ReturnType = typeof(NPC))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void CreateDeerclops(FrameEventData evt)
		{
			throw null;
		}

		// Token: 0x060038B5 RID: 14517 RVA: 0x0002C207 File Offset: 0x0002A407
		[global::Cpp2ILInjected.Token(Token = "0x6003F54")]
		[global::Cpp2ILInjected.Address(RVA = "0x747250", Offset = "0x747250", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DSTFilm), Member = "CreateDeerclops", MemberParameters = new object[] { typeof(FrameEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DSTFilm), Member = "FindFloorAt", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private NPC PlaceNPCOnGround(int type, Vector2 position)
		{
			throw null;
		}

		// Token: 0x060038B6 RID: 14518 RVA: 0x0002C20A File Offset: 0x0002A40A
		[global::Cpp2ILInjected.Token(Token = "0x6003F55")]
		[global::Cpp2ILInjected.Address(RVA = "0x747470", Offset = "0x747470", Length = "0x16C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DSTFilm), Member = "FindFloorAt", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void CreateChester(FrameEventData evt)
		{
			throw null;
		}

		// Token: 0x060038B7 RID: 14519 RVA: 0x0002C20D File Offset: 0x0002A40D
		[global::Cpp2ILInjected.Token(Token = "0x6003F56")]
		[global::Cpp2ILInjected.Address(RVA = "0x7475DC", Offset = "0x7475DC", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DSTFilm), Member = "FindFloorAt", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "set_BottomLeft", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void ControlPlayer(FrameEventData evt)
		{
			throw null;
		}

		// Token: 0x060038B8 RID: 14520 RVA: 0x0002C210 File Offset: 0x0002A410
		[global::Cpp2ILInjected.Token(Token = "0x6003F57")]
		[global::Cpp2ILInjected.Address(RVA = "0x7476F0", Offset = "0x7476F0", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FloatArray_3), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void StopBeforeCliff(FrameEventData evt)
		{
			throw null;
		}

		// Token: 0x060038B9 RID: 14521 RVA: 0x0002C213 File Offset: 0x0002A413
		[global::Cpp2ILInjected.Token(Token = "0x6003F58")]
		[global::Cpp2ILInjected.Address(RVA = "0x747760", Offset = "0x747760", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "ChangeDir", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "TargetClosest", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void TurnPlayerToTheLeft(FrameEventData evt)
		{
			throw null;
		}

		// Token: 0x060038BA RID: 14522 RVA: 0x0002C216 File Offset: 0x0002A416
		[global::Cpp2ILInjected.Token(Token = "0x6003F59")]
		[global::Cpp2ILInjected.Address(RVA = "0x747824", Offset = "0x747824", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "TargetClosest", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void DeerclopsAttack(FrameEventData evt)
		{
			throw null;
		}

		// Token: 0x060038BB RID: 14523 RVA: 0x0002C219 File Offset: 0x0002A419
		[global::Cpp2ILInjected.Token(Token = "0x6003F5A")]
		[global::Cpp2ILInjected.Address(RVA = "0x747388", Offset = "0x747388", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DSTFilm), Member = "PlaceNPCOnGround", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Vector2)
		}, ReturnType = typeof(NPC))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DSTFilm), Member = "CreateChester", MemberParameters = new object[] { typeof(FrameEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DSTFilm), Member = "ControlPlayer", MemberParameters = new object[] { typeof(FrameEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "SolidTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void FindFloorAt(Vector2 position, out int x, out int y)
		{
			throw null;
		}

		// Token: 0x04006884 RID: 26756
		[global::Cpp2ILInjected.Token(Token = "0x4007DAA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private NPC _deerclops;

		// Token: 0x04006885 RID: 26757
		[global::Cpp2ILInjected.Token(Token = "0x4007DAB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private Projectile _chester;

		// Token: 0x04006886 RID: 26758
		[global::Cpp2ILInjected.Token(Token = "0x4007DAC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private Vector2 _startPoint;

		// Token: 0x04006887 RID: 26759
		[global::Cpp2ILInjected.Token(Token = "0x4007DAD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private Item _oldItem;
	}
}
