   M S B A M L   `   `   `  ����I  EPROYECTO FINAL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:PROYECTO_FINALPROYECTO_FINAL  5   	       PROYECTO_FINAL.ajustes   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:PROYECTO_FINAL     5   	     � Title$  	ENTRE10TE��5   	   $	��900��6   $
��1600��6(   $��Multicolore)�5	   	    � WindowState$ 	Maximized=�5
   	    � 	Resources 5       �� 
TargetType 
  goBack �� Property �� Value �� 
TargetType �� CornerRadius J� Opacity	 ��Name��%�  &	        �� 5   
   " ��6   .�5      ��  �@�OverridesDefaultStyle$
 True��66   �� 5       �@�Cursor$
 Hand��6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      � #��z��6   .+�5      �� $ 15��6%   ���	#FFFF8A23$	 0.5Q�6N   �� 5      $	 MyContentPresenter��6/   #��z��6K   $��Center=�5   +   $��Center=�6H   ���	#FFFFFCE9$��20(�5   L   5      5      5      5      5      5       .��5!      � ���	#FFFFFCE9.+�5#   
   �� -   5        
 ��Name$

 logo��5#      $��Center=�6   $	��200��6;   $��0,28,0,0q�6H   $	��Top=�6Z   $	��200��5$      $��media/logo.png��6   �� 5%   
   -   5         ��Name$ Nombre��5%      $��	ENTRE10TE��6    $��Center=�64   $��	0,248,0,0q�6Q   $	��Top=�6d   $��80(�5&      $��Multicolore )�6   ���	#FFFF8A23��68   Z� 6N   �� 5)   
   -   5        $
��Left=�5)      $��1480,28,0,0q�6,   $	��Top=�6A   $��40��6Y   $��40��6e   #��[  6p   .��5+      ��  �� Orientation$ 
Horizontal=�6   .+�5,      �� $
��Left=�6   $��35��63   $	��Top=�6?   $��35��6W   $��/goback.png��6b   5-      5.      �� 51   
   $D��>© ENTRE10TE - Proyecto final de grado por Jane Orosco Damulog��6   $��Center=�6X   $��	0,760,0,0q�52      $	��Top=�6#   $��20(�6;   $��Multicolore )�6I   ���	#FF9A9A9A6c   � 54   
   $	��500��6   $
��1000��6   $��Center=�6)   $	��Top=�6F   $��	0,376,0,0q�6^    � ColumnDefinitions 55      �� 56      $	��100 �6#   �� 57      $
��155* �6#   �� 58      $
��155* �6#   �� 59      $	��100 �6#    � RowDefinitions 5<      �� 5=      $��80 �6    �� 5>      $��* �6    �� 5?      $	��120 �6    .+�5B      �� $��Center=�6   $��4��61   $��0��6E   $��Ajustes��6R   $��50(�6d   �� 5D      $��Pantalla Completa��6   $
��Left=�60   $��30(�6K   $��1��6Y   $��1��6i   �� 5E      $�� ��6   $
��Left=�6"    d� 	IsChecked$
 TrueY�6=    �� 	ClickMode$ Press=�6N   $��2��6`   $��1��6p   $��32,16,0,268q�6}   $��16��6�   �� 5G      $��Sonido��6   $
��Left=�6%   $��30(�6@   $��1��6N   $��1��6^   $��41��6k   $��Bottom=�6w   $��	0,0,0,216q�6�   �� 5H      $
��Left=�6   $��	32,55,0,0q�60   $	��Top=�6C   $	��120��6[   $��2��6g   $��1��6w   �� 5K      $��Brillo��6   $
��Left=�6%   $��30(�6@   $��1��6N   $��1��6^   $��44��6k   $��Bottom=�6w   $��	0,0,0,167q�6�   �� 5L      $
��Left=�6   $��
32,102,0,0q�60   $	��Top=�6D   $	��120��6\   $��2��6h   $��1��6x   �� 5N      $��Notificaciones��6   $��30(�6-   $��1��6;   $��1��6K   $��0,133,0,120q�6X   	� 5O      $��Si��6   $
��Left=�6'   $��2��6B   $��1��6R   $��32,150,0,130q�6_   $��20(�6u   	� 5P      $��No��6   $
��Left=�6'   $��2��6B   $��1��6R   $��92,152,0,128q�6_   $��20(�6u   5R      5U      5V      