﻿namespace Microsoft.Maui.Graphics.Controls
{
    public partial class EditorHandler : MixedGraphicsControlHandler<IEditorDrawable, IEditor, GraphicsEditor>
	{
		protected override GraphicsEditor CreateNativeView()
		{
			return new GraphicsEditor(Context!);
		}
	}
}