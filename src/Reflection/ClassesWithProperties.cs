﻿#pragma warning disable 0649

using Rbx2Source.Assembler;
using Rbx2Source.Coordinates;
using Rbx2Source.Web;

namespace Rbx2Source.Reflection
{
    class Accoutrement : Instance
    {
        public CFrame AttachmentPoint;
    }

    class Attachment : Instance
    {
        public CFrame CFrame;
        public bool Visible;
    }

    class CharacterMesh : Instance
    {
        public int BaseTextureId;
        public Limb BodyPart;
        public int MeshId;
        public int OverlayTextureId;
    }

    class CylinderMesh : DataModelMesh 
    {
        public bool UsingSuperAwkwardHeadProtocol;
        public string HeadAssetName;
    }

    class DataModelMesh : Instance
    {
        public Vector3 Scale;
        public Vector3 Offset;
        public Vector3 VertexColor;
    }

    class Keyframe : Instance
    {
        public float Time;
    }

    class KeyframeSequence : Instance
    {
        public bool Loop = true;
        public AnimationPriority Priority = AnimationPriority.Core;
        public AvatarType AvatarType = AvatarType.Unknown;
        public float TimeScale = 1f;
    }

    class MeshPart : Part
    {
        public string MeshID;
        public string TextureID;
        public Vector3 InitialSize;
    }

    class Part : Instance
    {
        public float Transparency;
        public float Reflectance;
        public CFrame CFrame;
        public int BrickColor;

        // note: the XML reflection is case sensitive :/

        public Vector3 size;
        public PartType shape = PartType.Block;

        public Vector3 Size
        {
            get { return size; }
            set { size = value; }
        }

        public PartType Shape
        {
            get { return shape; }
            set { shape = value; }
        }
    }

    class Pose : Instance
    {
        public CFrame CFrame;
        public EasingDirection PoseEasingDirection;
        public EasingStyle PoseEasingStyle;
        public float Weight;
    }

    class SpecialMesh : DataModelMesh
    {
        public string MeshId;
        public string TextureId;
        public MeshType MeshType;
    }
}
