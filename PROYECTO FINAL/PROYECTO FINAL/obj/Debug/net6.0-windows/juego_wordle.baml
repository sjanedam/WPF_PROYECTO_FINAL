   M S B A M L   `   `   `  ����I  EPROYECTO FINAL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:PROYECTO_FINALPROYECTO_FINAL  5   	   !    PROYECTO_FINAL.juego_wordle   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:PROYECTO_FINAL     5   	     � Title$  	ENTRE10TE��5   	   $	��900��6   $
��1600��6(   $��Multicolore)�5	   	    � WindowState$ 	Maximized=�5
   	    � 	Resources 5       �� 
TargetType 
  estilo �� Property �� Value �� 
TargetType ��Name 	 boton �� CornerRadius	 �� Triggers
 P� Property P� Value 
 goBack J� Opacity��%�  &	        &	 �    &	 �    �� 5   
   " ��6   .�5      ��  �@�OverridesDefaultStyle$
 True��66   �� 5       � ��
 � ���6+   �� 5       �@�Cursor$
 Hand��6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      � #��z��6   .+�5      �� $ MyContentPresenter��6/   #��z��5   +   $��Center=�5   +   $��Center=�5   +   5      5      5      5      �� 5!   
   " ��6   .�5"      ��  �@�OverridesDefaultStyle$
 True��66   �� 5#       �@�Cursor$
 Hand��6'   �� 5%       � �� 5&      �� 5'      " ��6&   .R�5(      � #��z��6   .+�5)      �� $ 25��6%   ���	#FFFF8A2367   �� 5*      $ MyContentPresenter��6/   #��z��6K   $��Center=�5+   +   $��Center=�6H   ���	#FFFFFCE9$��40(�5,   L   5-      5.      5/      51      	 53      P� 54      
 �@J�IsMouseOver$
 True��61   . �55      ��  � �� 56      �� 57      " ��6.   .R�58   "   � #��z��6'   .+�59   &   �� $ 25��6-   ���#FACC8D6?   �� 5:   &   $ MyContentPresenter��67   #��z��6S   $��Center=�5;   +   $��Center=�6H   ���	#FFFFFCE9$��39(�5<   L   5=   '   5>   #   5?      5A      5B      5D      �� 5F   
   " ��6   .�5G      ��  �@�OverridesDefaultStyle$
 True��66   �� 5H       �@�Cursor$
 Hand��6'   �� 5J       � �� 5K      �� 5L      " ��6&   .R�5M      � #��z��6   .+�5N      �� $ 15��6%   ���	#FFFF8A23$	 0.5Q�6N   �� 5O      $ MyContentPresenter��6/   #��z��6K   $��Center=�5P   +   $��Center=�6H   ���	#FFFFFCE9$��20(�5Q   L   5R      5S      5T      5V      5W      5X      .��5Y      � ���	#FFFFFCE9.+�5[   
   �� -   5        $
��Left=�5[      $��1480,28,0,0q�6,   $	��Top=�6A   $��40��6Y   $��40��6e   #��[ 6p   .��5]      ��  �� Orientation$ 
Horizontal=�6   .+�5^      �� $
��Left=�6   $��35��63   $	��Top=�6?   $��35��6W   $��/goback.png��6b   5_      5`      � 5b   
   -   5         �Name$ Panel��5b      $	��400��6   $	��400��6*   $��Center=�67   $	��Top=�6T   $��	0,100,0,0q�6l    � ColumnDefinitions 5d      �� 5e      $��1* �6#   �� 5f      $��1* �6#   �� 5g      $��1* �6#   �� 5h      $��1* �6#    � RowDefinitions 5j      �� 5k      $��1* �6    �� 5l      $��1* �6    �� 5m      $��1* �6    �� 5n      $��1* �6    .+�5q      �� -   5         ��Name$ Boton01��5q      #��[  6Q   $��Multicolore)�5r      $��60(�62   $��10, 10, 10, 10q�6@   ��5q   :   Z� 5r   @   �� 5s      -   5        $ Boton02��5s      #��[  6Q   $��Multicolore)�5t      $��60(�62   $��1��6@   $��10, 10, 10, 10q�6P   ��5s   :   Z� 5t   P   �� 5u      -   5        $ Boton03��5u      #��[  6Q   $��Multicolore)�5v      $��60(�62   $��2��6@   $��10, 10, 10, 10q�6P   ��5u   :   Z� 5v   P   �� 5w      -   5        $ Boton04��5w      #��[  6Q   $��Multicolore)�5x      $��60(�62   $��3��6@   $��10, 10, 10, 10q�6P   ��5w   :   Z� 5x   P   �� 5z      -   5        $ Boton05��5z      #��[  6Q   $��Multicolore)�5{      $��60(�62   $��10, 10, 10, 10q�6@   $��1��6X   ��5z   :   Z� 5{   X   �� 5|      -   5        $ Boton06��5|      #��[  6Q   $��Multicolore)�5}      $��60(�62   $��1��6@   $��1��6P   $��10, 10, 10, 10q�6]   ��5|   :   Z� 5}   ]   �� 5~      -	   5        $ Boton07��5~      #��[  6Q   $��Multicolore)�5      $��60(�62   $��2��6@   $��1��6P   $��10, 10, 10, 10q�6]   ��5~   :   Z� 5   ]   �� 5�      -
   5        $ Boton08��5�      #��[  6Q   $��Multicolore)�5�      $��60(�62   $��3��6@   $��1��6P   $��10, 10, 10, 10q�6]   ��5�   :   Z� 5�   ]   �� 5�      -   5        $ Boton09��5�      #��[  6Q   $��Multicolore)�5�      $��60(�62   $��10, 10, 10, 10q�6@   $��2��6X   ��5�   :   Z� 5�   X   �� 5�      -   5        $ Boton10��5�      #��[  6Q   $��Multicolore)�5�      $��60(�62   $��1��6@   $��2��6P   $��10, 10, 10, 10q�6]   ��5�   :   Z� 5�   ]   �� 5�      -   5        $ Boton11��5�      #��[  6Q   $��Multicolore)�5�      $��60(�62   $��2��6@   $��2��6P   $��10, 10, 10, 10q�6]   ��5�   :   Z� 5�   ]   �� 5�      -   5        $ Boton12��5�      #��[  6Q   $��Multicolore)�5�      $��60(�62   $��3��6@   $��2��6P   $��10, 10, 10, 10q�6]   ��5�   :   Z� 5�   ]   �� 5�      -   5        $ Boton13��5�      #��[  6Q   $��Multicolore)�5�      $��60(�62   $��10, 10, 10, 10q�6@   $��3��6X   ��5�   :   Z� 5�   X   �� 5�      -   5        $ Boton14��5�      #��[  6Q   $��Multicolore)�5�      $��60(�62   $��1��6@   $��3��6P   $��10, 10, 10, 10q�6]   ��5�   :   Z� 5�   ]   �� 5�      -   5        $ Boton15��5�      #��[  6Q   $��Multicolore)�5�      $��60(�62   $��2��6@   $��3��6P   $��10, 10, 10, 10q�6]   ��5�   :   Z� 5�   ]   �� 5�      -   5        $ Boton16��5�      #��[  6Q   $��Multicolore)�5�      $��60(�62   $��3��6@   $��3��6P   $��10, 10, 10, 10q�6]   ��5�   :   Z� 5�   ]   5�      �� 5�   
   -   5        $��Jugar��5�      $��Center=�6!   $��	0,685,0,0q�6>   $	��Top=�6Q   #��[ 5�      $	��400��60   $��50��6<   6H   �� 5�   
   -   5         ��Name$ guess��5�   O   $��Center=�5�      $��	0,581,0,0q�6/    �� TextWrapping$
 Wrap=�6B   $��TextBox��6V   $	��Top=�6e   $	��400��5�      $��40��6   $��30(�6*    �� TextAlignment$ Center=�68   6O   �� 5�   
   $G��ATienes que averiguar la palabra (de 4 letras) en cuatro intentos.��6   $
��Left=�5�      $��78��6+   $	��Top=�67   $	��365��6O    �� TextAlignment$ Justify=�5�      $
��Wrap=�6,   $��20(�6@   
��� ���$��1066,201,0,0q�6b   �� 5�   
   $h��bSi la letra se encuentra en la posición adecuada, entonces se coloreará el fondo de color verde.��6   $
��Left=�5�      $	��100��6+   $	��Top=�68   $	��365��6P   $ Justify=�5�      $
��Wrap=�6,   $��20(�6@   
��� ���$��1066,284,0,0q�6b   �� 5�   
   $���|Si la letra se encuentra en la palabra, pero no en la posición adecuada, entonces se coloreará el fondo de color amarillo.��6   $
��Left=�5�      $	��130��6+   $	��Top=�68   $	��365��6P   $ Justify=�5�      $
��Wrap=�6,   $��20(�6@   
��� ���$��1066,389,0,0q�6b   �� 5�   
   $_��YSi la letra no se encuentra en la palabra, entonces se coloreará el fondo de color gris.��6   $
��Left=�5�      $	��108��6+   $	��Top=�68   $	��365��6P   $ Justify=�5�      $
��Wrap=�6,   $��20(�6@   
��� ���$��1066,513,0,0q�6b   �� 5�   
   -   5         ��Name$ Puntos��5�   {   ���#22B3F0$��80(�6%   $
��Left=�63   $	��Top=�6N   $��294,185,0,0q�6f   6{   �� 5�   
   $��Reglas��6   $
��Left=�6!   $��1144,100,0,0q�6<   $	��Top=�6R   $��50(�6j   
��� ���6x   �� 5�   
   $
��Left=�6   $��5��6/   $��1150,172,0,0q�6:   
��� ���$	��Top=�6^   $	��204��6v   �� 5�   
   $��Puntuación��6   $
��Left=�6%   $��192,100,0,0q�6@   $	��Top=�6U   $��50(�6m   
��� ���6{   �� 5�   
   $
��Left=�6   $��4��6/   $��176,170,0,0q�6:   
��� ���$	��Top=�6]   $	��382��6u   5�      5�      