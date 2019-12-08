using System;

using Swift.Interop;
using SwiftUI.Interop;

namespace SwiftUI
{
	public interface IView : ISwiftValue
	{
		new ViewType SwiftType { get; }
	}

	public interface IBlittableView<T> : IView, ISwiftBlittableStruct<T>
		where T : unmanaged, IBlittableView<T>
	{
	}
}
