﻿#3 tema: darbalaukio aplikacijos II (aplikacijos paremtos WPF) - Mini užduotys - 4 užd.

##Sąlyga

- **Sąlyga**: Sukurkite WPF programėlę, kuri susidėtų iš teksto įvedimo lauko ir mygtuko, paspaudus mygtuką, teksto spalva pasikeistų į raudoną. Taip pat visi elementai (mygtukas ir teksto laukelis) turi būti animuoti - suktis 3D erdvėje apie Z ašį.

##Patarimai

1. 3D efektui pasiekti visus formos elementus sudėkite į elementą "Viewport2DVisual3D", o jį idėkite į elementą "Viewport3D".
2. Pradėti programėlę galite nuo šio pavyzdžio:
	
```xml	
<Viewport3D>
	<Viewport3D.Camera>
		<PerspectiveCamera Position="0, 0, 4"/>
	</Viewport3D.Camera>
	<Viewport2DVisual3D x:Name="v2dv3d">
		<Viewport2DVisual3D.Transform>
			<RotateTransform3D>
				<RotateTransform3D.Rotation>
					<AxisAngleRotation3D Angle="0" Axis="0, 1, 0" />
				</RotateTransform3D.Rotation>
			</RotateTransform3D>
		</Viewport2DVisual3D.Transform>
		<Viewport2DVisual3D.Geometry>
			<MeshGeometry3D Positions="-1,1,0 -1,-1,0 1,-1,0 1,1,0"
					TextureCoordinates="0,0 0,1 1,1 1,0" TriangleIndices="0 1 2 0 2 3"/>
		</Viewport2DVisual3D.Geometry>

		<Viewport2DVisual3D.Material>
			<DiffuseMaterial Viewport2DVisual3D.IsVisualHostMaterial="True" Brush="White"/>
		</Viewport2DVisual3D.Material>
		<Button Content="Hello, 3D">
			<Button.Triggers>
				<EventTrigger RoutedEvent="FrameworkElement.Loaded">
					<BeginStoryboard>
						<Storyboard RepeatBehavior="Forever">
							<Rotation3DAnimation Storyboard.TargetName="v2dv3d"
													Storyboard.TargetProperty="(Viewport2DVisual3D.Transform).(RotateTransform3D.Rotation)"
													Duration="0:0:2"
													BeginTime="0:0:0">
								<Rotation3DAnimation.From>
									<AxisAngleRotation3D Angle="0" Axis="0, 1, 0" />
								</Rotation3DAnimation.From>
								<Rotation3DAnimation.To>
									<AxisAngleRotation3D Angle="90" Axis="0, 1, 0" />
								</Rotation3DAnimation.To>
							</Rotation3DAnimation>
							<Rotation3DAnimation Storyboard.TargetName="v2dv3d"
													Storyboard.TargetProperty="(Viewport2DVisual3D.Transform).(RotateTransform3D.Rotation)"
													Duration="0:0:2"
													BeginTime="0:0:2">
								<Rotation3DAnimation.From>
									<AxisAngleRotation3D Angle="-90" Axis="0, 1, 0" />
								</Rotation3DAnimation.From>
								<Rotation3DAnimation.To>
									<AxisAngleRotation3D Angle="0" Axis="0, 1, 0" />
								</Rotation3DAnimation.To>
							</Rotation3DAnimation>
						</Storyboard>
					</BeginStoryboard>
				</EventTrigger>
			</Button.Triggers>
		</Button>
	</Viewport2DVisual3D>
	<ModelVisual3D>
		<ModelVisual3D.Content>
			<DirectionalLight Color="#FFFFFFFF" Direction="0,0,-1"/>
		</ModelVisual3D.Content>
	</ModelVisual3D>
</Viewport3D>
```