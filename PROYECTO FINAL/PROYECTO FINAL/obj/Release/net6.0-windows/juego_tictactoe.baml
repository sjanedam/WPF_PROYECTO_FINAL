   M S B A M L   `   `   `  ���� I  EPROYECTO FINAL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:PROYECTO_FINALPROYECTO_FINAL  $    PROYECTO_FINAL.juego_tictactoe   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:PROYECTO_FINAL       � Title$  	ENTRE10TE��$	��900��$
��1600��$��Multicolore)� � WindowState$ 	Maximized=� � 	Resources  �� 
TargetType 
  estilo �� Property �� Value �� 
TargetType ��Name �� Triggers	 P� Property
 P� Value 	 boton �� CornerRadius 
 goBack J� Opacity��%e  &	        &	 q    &	 >    �� " ��.���  �@�OverridesDefaultStyle$
 True����  � �� �	#FFFF8A23��  �@�Cursor$
 Hand����  � �� �� " ��.R�� #��z��.+��� $ MyContentPresenter��#��z��$��Center=�$��Center=� P� 	 � {�$
 False��. ���  � �� �#22B3F0��  � ��
 �����P� 	 � {�$

 True��. ���  � �� �	#FFFF8A23�� " ��.���  �@�OverridesDefaultStyle$
 True����  �@�Cursor$
 Hand����  � �� �� " ��.R�� #��z��.+��� $ 25�����	#FFFF8A23�� $ MyContentPresenter��#��z��$��Center=�$��Center=����	#FFFFFCE9$��40(� P� 	 �@J�IsMouseOver$

 True��. ���  � �� �� " ��.R�� #��z��.+��� $ 25�����#FACC8D�� $ MyContentPresenter��#��z��$��Center=�$��Center=����	#FFFFFCE9$��39(��� " ��.���  �@�OverridesDefaultStyle$
 True����  �@�Cursor$
 Hand����  � �� �� " ��.R�� #��z��.+��� $ 15�����	#FFFF8A23$	 0.5Q��� $ MyContentPresenter��#��z��$��Center=�$��Center=����	#FFFFFCE9$��20(�.��� ���	#FFFFFCE9.+��� -   $
��Left=�$��1480,28,0,0q�$	��Top=�$��40��$��40��#��[ .����  �� Orientation$ 
Horizontal=�.+��� $
��Left=�$��35��$	��Top=�$��35��$��/goback.png��� -    �Name$ Panel��$	��500��$	��500��$��Center=�$	��Top=�$��	0,121,0,0q� � ColumnDefinitions �� $��1* ��� $��1* ��� $��1* � � RowDefinitions �� $��1* ��� $��1* ��� $��1* �.+��� -    ��Name$ Boton01��#��[  $��Multicolore)�$	��120(�$��10, 10, 10, 10q���Z� �� -   $ Boton02��#��[  $��Multicolore)�$	��120(�$��1��$��10, 10, 10, 10q���Z� �� -   $ Boton03��#��[  $��Multicolore)�$	��120(�$��2��$��10, 10, 10, 10q���Z� �� -   $ Boton04��#��[  $��Multicolore)�$	��120(�$��1��$��10, 10, 10, 10q���Z� �� -   $ Boton05��#��[  $��Multicolore)�$	��120(�$��1��$��1��$��10, 10, 10, 10q���Z� �� -   $ Boton06��#��[  $��Multicolore)�$	��120(�$��2��$��1��$��10, 10, 10, 10q���Z� �� -	   $ Boton07��#��[  $��Multicolore)�$	��120(�$��2��$��10, 10, 10, 10q���Z� �� -
   $ Boton08��#��[  $��Multicolore)�$	��120(�$��1��$��2��$��10, 10, 10, 10q���Z� �� -   $ Boton09��#��[  $��Multicolore)�$	��120(�$��2��$��2��$��10, 10, 10, 10q���Z� �� -   $��Resetear juego��$��Center=�$��	0,680,0,0q�$	��Top=�$	��600��$��70��#��[ �� -    ��Name$ Turno��$��Center=�$��0,60,0,0q�$	��Top=�$��40(�$��Turno:���� $��200,228,0,0q�$��40(�$��Puntos de X��
��� ���$
��Left=�$	��Top=��� -   $ PuntoX��$��285,289,0,0q�$��80(�$�� �����#22B3F0$
��Left=�$	��Top=��� 
��� ���$	��282��$��5��$��200,289,0,0q�$
��Left=�$	��Top=��� $��1116,228,0,0q�$��40(�$��Puntos de O��
��� ���$
��Left=�$	��Top=��� -   $ PuntoO��$��1205,289,0,0q�$��80(�$�� �����#22B3F0$
��Left=�$	��Top=��� 
��� ���$	��290��$��5��$��1116,289,0,0q�$
��Left=�$	��Top=�