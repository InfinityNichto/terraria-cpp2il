using System;
using System.ComponentModel;
using Cpp2ILInjected;

namespace UnityEngine
{
	[global::Cpp2ILInjected.Token(Token = "0x2000009")]
	public enum EventType
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000021")]
		MouseDown,
		[global::Cpp2ILInjected.Token(Token = "0x4000022")]
		MouseUp,
		[global::Cpp2ILInjected.Token(Token = "0x4000023")]
		MouseMove,
		[global::Cpp2ILInjected.Token(Token = "0x4000024")]
		MouseDrag,
		[global::Cpp2ILInjected.Token(Token = "0x4000025")]
		KeyDown,
		[global::Cpp2ILInjected.Token(Token = "0x4000026")]
		KeyUp,
		[global::Cpp2ILInjected.Token(Token = "0x4000027")]
		ScrollWheel,
		[global::Cpp2ILInjected.Token(Token = "0x4000028")]
		Repaint,
		[global::Cpp2ILInjected.Token(Token = "0x4000029")]
		Layout,
		[global::Cpp2ILInjected.Token(Token = "0x400002A")]
		DragUpdated,
		[global::Cpp2ILInjected.Token(Token = "0x400002B")]
		DragPerform,
		[global::Cpp2ILInjected.Token(Token = "0x400002C")]
		DragExited = 15,
		[global::Cpp2ILInjected.Token(Token = "0x400002D")]
		Ignore = 11,
		[global::Cpp2ILInjected.Token(Token = "0x400002E")]
		Used,
		[global::Cpp2ILInjected.Token(Token = "0x400002F")]
		ValidateCommand,
		[global::Cpp2ILInjected.Token(Token = "0x4000030")]
		ExecuteCommand,
		[global::Cpp2ILInjected.Token(Token = "0x4000031")]
		ContextClick = 16,
		[global::Cpp2ILInjected.Token(Token = "0x4000032")]
		MouseEnterWindow = 20,
		[global::Cpp2ILInjected.Token(Token = "0x4000033")]
		MouseLeaveWindow,
		[global::Cpp2ILInjected.Token(Token = "0x4000034")]
		TouchDown = 30,
		[global::Cpp2ILInjected.Token(Token = "0x4000035")]
		TouchUp,
		[global::Cpp2ILInjected.Token(Token = "0x4000036")]
		TouchMove,
		[global::Cpp2ILInjected.Token(Token = "0x4000037")]
		TouchEnter,
		[global::Cpp2ILInjected.Token(Token = "0x4000038")]
		TouchLeave,
		[global::Cpp2ILInjected.Token(Token = "0x4000039")]
		TouchStationary,
		[Obsolete("Use MouseDown instead (UnityUpgradable) -> MouseDown", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x400003A")]
		mouseDown = 0,
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use MouseUp instead (UnityUpgradable) -> MouseUp", true)]
		[global::Cpp2ILInjected.Token(Token = "0x400003B")]
		mouseUp,
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use MouseMove instead (UnityUpgradable) -> MouseMove", true)]
		[global::Cpp2ILInjected.Token(Token = "0x400003C")]
		mouseMove,
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use MouseDrag instead (UnityUpgradable) -> MouseDrag", true)]
		[global::Cpp2ILInjected.Token(Token = "0x400003D")]
		mouseDrag,
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use KeyDown instead (UnityUpgradable) -> KeyDown", true)]
		[global::Cpp2ILInjected.Token(Token = "0x400003E")]
		keyDown,
		[Obsolete("Use KeyUp instead (UnityUpgradable) -> KeyUp", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x400003F")]
		keyUp,
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use ScrollWheel instead (UnityUpgradable) -> ScrollWheel", true)]
		[global::Cpp2ILInjected.Token(Token = "0x4000040")]
		scrollWheel,
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use Repaint instead (UnityUpgradable) -> Repaint", true)]
		[global::Cpp2ILInjected.Token(Token = "0x4000041")]
		repaint,
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use Layout instead (UnityUpgradable) -> Layout", true)]
		[global::Cpp2ILInjected.Token(Token = "0x4000042")]
		layout,
		[Obsolete("Use DragUpdated instead (UnityUpgradable) -> DragUpdated", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x4000043")]
		dragUpdated,
		[Obsolete("Use DragPerform instead (UnityUpgradable) -> DragPerform", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x4000044")]
		dragPerform,
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use Ignore instead (UnityUpgradable) -> Ignore", true)]
		[global::Cpp2ILInjected.Token(Token = "0x4000045")]
		ignore,
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use Used instead (UnityUpgradable) -> Used", true)]
		[global::Cpp2ILInjected.Token(Token = "0x4000046")]
		used
	}
}
