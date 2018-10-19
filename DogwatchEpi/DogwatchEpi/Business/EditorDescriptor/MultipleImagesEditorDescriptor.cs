using System;
using System.Collections.Generic;
using DogwatchEpi;
using EPiServer.Shell.ObjectEditing.EditorDescriptors;

namespace DogwatchEpi
{
  [EditorDescriptorRegistration(TargetType = typeof(MultipleImages), UIHint = "MultipleImagesEditor")]
  public class MultipleImagesEditorDescriptor : EditorDescriptor
  {
    public override void ModifyMetadata(EPiServer.Shell.ObjectEditing.ExtendedMetadata metadata, IEnumerable<Attribute> attributes)
    {
        ClientEditingClass = "multipleimages/editors/MultipleImagesEditor";

      base.ModifyMetadata(metadata, attributes);
    }
  }
}