   M S B A M L   `   `   `  ���� I  EPROYECTO FINAL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:PROYECTO_FINALPROYECTO_FINAL  !    PROYECTO_FINAL.juego_wordle   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:PROYECTO_FINAL       � Title$  	ENTRE10TE��$	��900��$
��1600��$��Multicolore)� � WindowState$ 	Maximized=� � 	Resources  �� 
TargetType 
  estilo �� Property �� Value �� 
TargetType ��Name 	 boton �� CornerRadius	 �� Triggers
 P� Property P� Value 
 goBack J� Opacity��%�  &	        &	 �     &	 �    �� " ��.���  �@�OverridesDefaultStyle$
 True����  � ��
 � �����  �@�Cursor$
 Hand����  � �� �� " ��.R�� #��z��.+��� $ MyContentPresenter��#��z��$��Center=�$��Center=��� " ��.���  �@�OverridesDefaultStyle$
 True����  �@�Cursor$
 Hand����  � �� �� " ��.R�� #��z��.+��� $ 25�����	#FFFF8A23�� $ MyContentPresenter��#��z��$��Center=�$��Center=����	#FFFFFCE9$��40(�	 P� 
 �@J�IsMouseOver$
 True��. ���  � �� �� " ��.R�� #��z��.+��� $ 25�����#FACC8D�� $ MyContentPresenter��#��z��$��Center=�$��Center=����	#FFFFFCE9$��39(��� " ��.���  �@�OverridesDefaultStyle$
 True����  �@�Cursor$
 Hand����  � �� �� " ��.R�� #��z��.+��� $ 15�����	#FFFF8A23$	 0.5Q��� $ MyContentPresenter��#��z��$��Center=�$��Center=����	#FFFFFCE9$��20(�.��� ���	#FFFFFCE9.+��� -   $
��Left=�$��1480,28,0,0q�$	��Top=�$��40��$��40��#��[ .����  �� Orientation$ 
Horizontal=�.+��� $
��Left=�$��35��$	��Top=�$��35��$��/goback.png��� -    �Name$ Panel��$	��400��$	��400��$��Center=�$	��Top=�$��	0,100,0,0q� � ColumnDefinitions �� $��1* ��� $��1* ��� $��1* ��� $��1* � � RowDefinitions �� $��1* ��� $��1* ��� $��1* ��� $��1* �.+��� -    ��Name$ Boton01��#��[  $��Multicolore)�$��60(�$��10, 10, 10, 10q���Z� �� -   $ Boton02��#��[  $��Multicolore)�$��60(�$��1��$��10, 10, 10, 10q���Z� �� -   $ Boton03��#��[  $��Multicolore)�$��60(�$��2��$��10, 10, 10, 10q���Z� �� -   $ Boton04��#��[  $��Multicolore)�$��60(�$��3��$��10, 10, 10, 10q���Z� �� -   $ Boton05��#��[  $��Multicolore)�$��60(�$��10, 10, 10, 10q�$��1����Z� �� -   $ Boton06��#��[  $��Multicolore)�$��60(�$��1��$��1��$��10, 10, 10, 10q���Z� �� -	   $ Boton07��#��[  $��Multicolore)�$��60(�$��2��$��1��$��10, 10, 10, 10q���Z� �� -
   $ Boton08��#��[  $��Multicolore)�$��60(�$��3��$��1��$��10, 10, 10, 10q���Z� �� -   $ Boton09��#��[  $��Multicolore)�$��60(�$��10, 10, 10, 10q�$��2����Z� �� -   $ Boton10��#��[  $��Multicolore)�$��60(�$��1��$��2��$��10, 10, 10, 10q���Z� �� -   $ Boton11��#��[  $��Multicolore)�$��60(�$��2��$��2��$��10, 10, 10, 10q���Z� �� -   $ Boton12��#��[  $��Multicolore)�$��60(�$��3��$��2��$��10, 10, 10, 10q���Z� �� -   $ Boton13��#��[  $��Multicolore)�$��60(�$��10, 10, 10, 10q�$��3����Z� �� -   $ Boton14��#��[  $��Multicolore)�$��60(�$��1��$��3��$��10, 10, 10, 10q���Z� �� -   $ Boton15��#��[  $��Multicolore)�$��60(�$��2��$��3��$��10, 10, 10, 10q���Z� �� -   $ Boton16��#��[  $��Multicolore)�$��60(�$��3��$��3��$��10, 10, 10, 10q���Z� �� -   $��Jugar��$��Center=�$��	0,685,0,0q�$	��Top=�#��[ $	��400��$��50���� -    ��Name$ guess��$��Center=�$��	0,581,0,0q� �� TextWrapping$
 Wrap=�$��TextBox��$	��Top=�$	��400��$��40��$��30(� �� TextAlignment$ Center=��� $G��ATienes que averiguar la palabra (de 4 letras) en cuatro intentos.��$
��Left=�$��78��$	��Top=�$	��365�� �� TextAlignment$ Justify=�$
��Wrap=�$��20(�
��� ���$��1066,201,0,0q��� $h��bSi la letra se encuentra en la posición adecuada, entonces se coloreará el fondo de color verde.��$
��Left=�$	��100��$	��Top=�$	��365��$ Justify=�$
��Wrap=�$��20(�
��� ���$��1066,284,0,0q��� $���|Si la letra se encuentra en la palabra, pero no en la posición adecuada, entonces se coloreará el fondo de color amarillo.��$
��Left=�$	��130��$	��Top=�$	��365��$ Justify=�$
��Wrap=�$��20(�
��� ���$��1066,389,0,0q��� $_��YSi la letra no se encuentra en la palabra, entonces se coloreará el fondo de color gris.��$
��Left=�$	��108��$	��Top=�$	��365��$ Justify=�$
��Wrap=�$��20(�
��� ���$��1066,513,0,0q��� -    ��Name$ Puntos�����#22B3F0$��80(�$
��Left=�$	��Top=�$��294,185,0,0q��� $��Reglas��$
��Left=�$��1144,100,0,0q�$	��Top=�$��50(�
��� ����� $
��Left=�$��5��$��1150,172,0,0q�
��� ���$	��Top=�$	��204���� $��Puntuación��$
��Left=�$��192,100,0,0q�$	��Top=�$��50(�
��� ����� $
��Left=�$��4��$��176,170,0,0q�
��� ���$	��Top=�$	��382��