﻿using AssetRipper.Export.UnityProjects.Configuration;

namespace AssetRipper.GUI.Electron.Pages.Settings.DropDown;

public sealed class ImageExportFormatDropDownSetting : DropDownSetting<ImageExportFormat>
{
	public static ImageExportFormatDropDownSetting Instance { get; } = new();

	public override string Title => Localization.ImageExportTitle;

	protected override string? GetDescription(ImageExportFormat value)
	{
		return Localization.ImageFormatDescription;
	}
}
