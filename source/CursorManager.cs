using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000015")]
public class CursorManager
{
	[Cpp2IlInjected.Token(Token = "0x2000764")]
	public struct TouchInput
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40077E8")]
		public readonly int TouchId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40077E9")]
		public readonly Vector2 TouchPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40077EA")]
		public readonly TouchPhase TouchPhase;

		[Cpp2IlInjected.Token(Token = "0x600483F")]
		[Cpp2IlInjected.Address(RVA = "0x441E80", Offset = "0x441E80", VA = "0x441E80")]
		public TouchInput(int id, Vector2 position, TouchPhase phase)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000765")]
	private struct CursorFirstContact
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40077EB")]
		public Vector2 position;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40077EC")]
		public DateTime time;
	}

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static CursorManager Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private int _touchCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public bool ActivateMouseMode;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private bool emuTouchFromMouse;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private bool fakeMouseActive;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private bool mouseActive;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private Vector2 fakeMousePosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private bool updatingSwitchTouches;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private List<TouchInput> UserSwitchTouches;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private bool emuMouseModeActive;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private bool updatingEMUMouseTouches;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private Vector3 emuMouseLastHWMousePosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public Vector2 EmuMousePosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private List<TouchInput> EMUMouseTouches;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private List<TouchInput> PreviousEMUMouseTouches;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private List<Cursor> _cursors;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private List<CursorFirstContact> _cursorsInpacts;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public List<CursorInputLayer> Layers;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool EmuMouseModeActive
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x20C82F4", Offset = "0x20C82F4", VA = "0x20C82F4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x20C6AA8", Offset = "0x20C6AA8", VA = "0x20C6AA8")]
	public static CursorManager Create()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x20C6B14", Offset = "0x20C6B14", VA = "0x20C6B14")]
	public CursorManager()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x20C6CE4", Offset = "0x20C6CE4", VA = "0x20C6CE4")]
	public bool IsCursorActive()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x20C6EE0", Offset = "0x20C6EE0", VA = "0x20C6EE0")]
	public int GetNumCursors()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x20C6F2C", Offset = "0x20C6F2C", VA = "0x20C6F2C")]
	public Cursor GetCursor(int index)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x20C6F98", Offset = "0x20C6F98", VA = "0x20C6F98")]
	public void UpdateCursors()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x20C6D40", Offset = "0x20C6D40", VA = "0x20C6D40")]
	private bool IsMouseActive(int index)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x20C7E10", Offset = "0x20C7E10", VA = "0x20C7E10")]
	private bool IsTouchScrollOnly(int touchIndex)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x20C8024", Offset = "0x20C8024", VA = "0x20C8024")]
	public int GetRealTouchCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x20C802C", Offset = "0x20C802C", VA = "0x20C802C")]
	public int GetTouchCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x20C7F5C", Offset = "0x20C7F5C", VA = "0x20C7F5C")]
	private int GetTouchId(int touchIndex)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x20C81A4", Offset = "0x20C81A4", VA = "0x20C81A4")]
	private int GetTouchIndex(int touchId)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x20C8310", Offset = "0x20C8310", VA = "0x20C8310")]
	public bool GetEMUMouseButton(int index)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x20C837C", Offset = "0x20C837C", VA = "0x20C837C")]
	public bool GetEMUMouseButtonDown(int index)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x20C83F8", Offset = "0x20C83F8", VA = "0x20C83F8")]
	public bool GetEMUMouseButtonUp(int index)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x20C846C", Offset = "0x20C846C", VA = "0x20C846C")]
	private TouchPhase GetTouchPhase(int touchIndex)
	{
		return default(TouchPhase);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x20C8800", Offset = "0x20C8800", VA = "0x20C8800")]
	private bool ShouldIgnoreTouch(int touchIndex)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x20C8858", Offset = "0x20C8858", VA = "0x20C8858")]
	private Vector2 GetTouchPosition(int touchIndex)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x20C89D4", Offset = "0x20C89D4", VA = "0x20C89D4")]
	private Vector2 GetTouchScroll(int touchIndex)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x20C8A70", Offset = "0x20C8A70", VA = "0x20C8A70")]
	private bool ShouldIgnoreForWorld(Vector2 position)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x20C8C28", Offset = "0x20C8C28", VA = "0x20C8C28")]
	private void UpdateMouseEMUTouches()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x20C74B0", Offset = "0x20C74B0", VA = "0x20C74B0")]
	private void UpdateCursorList()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x20C8E98", Offset = "0x20C8E98", VA = "0x20C8E98")]
	public void DrawCursorOverlay(SpriteBatch batch)
	{
	}
}
