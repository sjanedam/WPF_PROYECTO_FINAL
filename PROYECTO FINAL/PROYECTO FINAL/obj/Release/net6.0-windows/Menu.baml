   M S B A M L   `   `   `  ���� I  EPROYECTO FINAL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:PROYECTO_FINALPROYECTO_FINAL      PROYECTO_FINAL.Menu   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:PROYECTO_FINAL       � Title$  	ENTRE10TE��$	��900��$
��1600��$��Multicolore)� � WindowState$ 	Maximized=� � 	Resources    
font_style �� 
TargetType �� Property �� Value  tooltip_style  menu_boton_style �� 
TargetType ��Name J� SnapsToDevicePixels	 �� Triggers
 P� Property P� Value 
 estilo �� CornerRadius ��Name �� Triggers  estiloStack �� 	Resources��%j  &	        &	 �     &	 B    &	 �    &	 �    �� " ��.���  � ��$ Multicolore)���  � ��$ Center=���  � ��$
 Left=���  � ��
 �������  � ��$ 20(��� " _�.���  �@_�	Placement$ Right=���  � ��$ 40����  � ��$	 150����  � ��$ 20,0,0,0q���  � �� �	#FFFF8A23��  � ��
 ���� ��  � ��
 �������  � ��$ Multicolore)���  � ��$ 16(���  �@_�PlacementRectangle$ 60,0,0,0���  �@_�HorizontalOffset$ 15����  �@_�VerticalOffset$ 6����  �@_�HasDropShadow$
 True����  � ��$ Center=��� " d�.���  � �� �� " d�.R��� $ border��#��z��#��z��$
 True��	 P� 
 �@J�IsMouseOver$
 true��P� 
 �@d�	IsChecked$
 trueY��� " ��.���  �@�OverridesDefaultStyle$
 True����  �@�Cursor$
 Hand����  � �� �� " ��.R�� #��z��.+��� $ 20��
�������
���   �$��1q��� $ MyContentPresenter��#��z��$��Center=�$��Center=� P� 
 �@J�IsMouseOver$
 True��. ���  � �� �� " ��.R�� #��z��.+��� $ 20��
�������
���   �$��1q��� $ MyContentPresenter��#��z��$��Center=�$��Center=��� " �� ���� '��       " ��.���  � �� �	#FFFF8A23��  � ��$ 25(� P� 
 �@J�IsMouseOver$
 True��. ���  � ��
 �   �.��� .+�� ���	#FFFFFCE9.+��� -    ��Name$
 logo��$��Center=�$��84��$��0,28,0,0q�$	��Top=�$��84��$��media/logo.png���� -    ��Name$ Nombre��$��	ENTRE10TE��$��Center=�$��	0,114,0,0q�$	��Top=�$��35(�$��Multicolore )����	#FFFF8A23$��46��$	��209����Z� �� $D��>© ENTRE10TE - Proyecto final de grado por Jane Orosco Damulog��$��Center=�$��	0,760,0,0q�$	��Top=�$��20(�$��Multicolore )����	#FF9A9A9A�� $��Los más jugados��$
��Left=�$��150,150,0,0q�$	��Top=�$��40(�$��Multicolore)��� $
��Left=�$��7��$��150,210,0,0q����	#FFFF8A23$	��Top=�$	��100���� -   $
��Left=�$	��Top=�$	��470��$	��400��$��100,250,0,0q�#��[ .����  �� Orientation$ Vertical=�#��[ .+��� $��media/tresenraya.png��$	��350��$	��350���� -   $ tipo3en��$��x��$	��360���� -   $ 	nombre3en��$��Nombre��$	��360���� -   $��Center=�$	��Top=�$	��470��$	��400��$��	0,250,0,0q�#��[ .���� $ Vertical=�#��[ .+��� $��media/wordle.png��$	��350��$	��350���� -   $ tipoWord��$��X��$	��360���� -   $ 
nombreWord��$��Nombre��$	��360���� -	   $��Right=�$	��Top=�$	��470��$	��400��$��0,250,100,0q�#��[ .���� $ Vertical=�#��[ .+��� $��/flappymew.png��$	��350��$	��350���� -
   $ tipoMew��$��x��$	��360���� -   $ 	nombreMew��$��Nombre��$	��360��� -    �Name$ 
navegacion��$
��Left=�$��65�����	#FFFF8A23.+��� -    ��Name$ 
stackpanel��.+�� $��90��.+��� $��1��$��0��$��
75,-10,0,0q�$��MENÚ��
�������$��22(�
������ $
��Left=�$��Center=�#��[  d� -    d�Name$ 
menu_boton��$��0��$��Center=�$
��Left=�$��
18,-20,0,0q�$��30��$��30��$��0q�#��[ ����  �� ImageSource$ media/menu.png�� j� Stretch$
 None=� � Triggers :�  :� RoutedEvent$ ToggleButton.Unchecked��.[��� .���� -    ��Name$ HideStackPanel��.��W�  �� 
TargetName$ 
navegacion�� �� TargetProperty$ Width� g� 	BeginTime	 0:0:0 W� From 230	 W� To 65  g� Duration$  0:0:0.2D�:� $ ToggleButton.Checked��.[��� .���� -   $ ShowStackPanel��.��W� $ 
navegacion��$ Width�	 0:0:0 65 230$  0:0:0.3D��� -   ! ��Name$! Listview��
������ 
������ $��Disabled=�.@��� -   $
��Left=�$��0,0,0,15q�.���� $ 
Horizontal=�$	��230��.+��� $��media/account.png��$
��None=�$��0,0,0,0q��� $��Salir��$��25,0,0,0q�#��[  " � ToolTip" _� -   # _�Name$# perfil_tooltip��$��Salir��#��[ �� -   $
��Left=�$��0,0,0,15q�.���� $ 
Horizontal=�$	��230��.+��� $��media/widgets.png��$
��None=�$��0,0,0,0q��� $��Juegos��$��25,0,0,0q�#��[  " _� -   $# juegos_tooltip��$��JUEGOS��#��[ �� -   $
��Left=�$��0,0,0,15q�.���� $ 
Horizontal=�$	��230��.+��� $��media/settings.png��$
��None=�$��0,0,0,0q��� $��Ajustes��$��25,0,0,0q�#��[  " _� -   $# ajustes_tooltip��$��AJUSTES��#��[ ���� " ��.���  � �� �� " ��.R��� $ Bd��$��50��#��z��#��z��#��z��$ �� Padding#$ z��$
 True��._��� #��z��# z #��z��	 ]� % ]� 
Conditions% �� & �� Property& �@J�IsMouseOver' �� Value$
' True��./��� ( �� 
TargetName$( Bd�� � �� �#CC5500�� $( Bd�� � �� �#CC5500