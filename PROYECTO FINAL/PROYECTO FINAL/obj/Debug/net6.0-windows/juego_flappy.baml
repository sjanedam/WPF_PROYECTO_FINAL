   M S B A M L   `   `   `  ����I  EPROYECTO FINAL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:PROYECTO_FINALPROYECTO_FINAL  5   	   !    PROYECTO_FINAL.juego_flappy   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:PROYECTO_FINAL     5   	     � Title$  	ENTRE10TE��5   	   $	��900��6   $
��1600��6(   $��Multicolore)�5	   	    � WindowState$ 	Maximized=�5
   	    � 	Resources 5       �� 
TargetType 
  goBack �� Property �� Value �� 
TargetType �� CornerRadius J� Opacity	 ��Name��%�  &	        �� 5   
   " ��6   .�5      ��  �@�OverridesDefaultStyle$
 True��66   �� 5       �@�Cursor$
 Hand��6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      � #��z��6   .+�5      �� $ 15��6%   ���	#FFFF8A23$	 0.5Q�6N   �� 5      $	 MyContentPresenter��6/   #��z��6K   $��Center=�5   +   $��Center=�6H   ���	#FFFFFCE9$��20(�5   L   5      5      5      5      5      5       .��5!      �� -   5        
 ��Name$
 Pantalla��5!   $   
����ح�$
|�True��6Z   .+�5#   
   �� $��
/nubes.png��6   $��224,47,224,198q�6$   
 � Tag$
 Nube��6<   6I   �� 5'   
    �� Left$	 100��6   
 �� Top$	 -41��6"   $	��352��63   $	��100��6@   $��/columna1.png��6L   $
 Obs1��6c   �� 5(   
   $	 100��6   $	 523��6"   $	��352��63   $	��100��6@   $��/columna1.png��6L   $
 Obs1��6c   $��Center=�6n   $	��Top=�6�   �� 5*   
   $	 373��6   $
 -195��6"   $	��352��64   $	��100��6A   $��/columna2.png��6M   $
 Obs2��6d   �� 5+   
   $	 373��6   $	 405��6"   $	��352��63   $	��100��6@   $��/columna2.png��6L   $
 Obs2��6c   �� 5-   
   $	 700��6   $	��352��6"   $	��100��6/   $��/columna2.png��6;   $
 Obs3��6R   $��Center=�6]   $	��Top=�6z   �� 5.   
   $	 700��6   $	 560��6"   $	��352��63   $	��100��6@   $��/columna1.png��6L   $
 Obs3��6c   $��Center=�6n   $	��Top=�6�   �� 51   
   -   5         ��Name$	 Mew��51   '   $��75��6   $��75��6   $��/mew.png��64   $	 365��6F   $ 20��6W   �� 54   
   -   5        $ Suelo��55      $
��Left=�54      $	��173��6+   $	��Top=�68   $
��1330��6P   $��/ground.png��55      $	 -30��64   $	 713��6F   �� 58   
   $
��Left=�6   $
��1000��6/   ���	#FFFFFCE9$	��Top=�6N   $	��600��6f   $
 1000��6r   $	 -58��6�   �� 5:   
   -   5        $
��Left=�5:      $��1480,28,0,0q�6,   $	��Top=�6A   $��40��6Y   $��40��6e   #��[  6p   .��5<      ��  �� Orientation$ 
Horizontal=�6   .+�5=      �� $
��Left=�6   $��35��63   $	��Top=�6?   $��35��6W   $��/goback.png��6b   5>      5?      �� 5A   
   
��� ���$��Puntuación��6$   $
 1190��69   $	 131��6L   $��30(�6]   �� 5B   
   
��� ���$	��226��6"   $��5��6.   $
 1190��69   $	 180��6L   �� 5C   
   -   5         ��Name$ 
Puntuacion��5C   %   ���#22B3F0$
 1247��69   $	 190��6L   $��80(�6]   $
��Left=�6k   $��Center=�6�   �� 5D   
   $0��*Para mover a Mew usa la barra espaciadora.��6   $
 1119��5E      $	 491��6#   $
��Left=�64   $	��Top=�6O   $��56��6g   $	��366��6s    �� TextAlignment$ Justify=�5F      $
��Wrap=�6,   $��20(�6@   
��� ���6N   �� 5G   
   $���~Pierdes cuando toques el suelo, el cielo o alguno de los pokeballs. Cuando pierdas, para reiniciar el juego, pulsa la tecla R.��6   $
 1115��5H      $	 552��6#   $
��Left=�64   $	��143��6O   $	��Top=�6\   $	��365��6t   $ Justify=�5I      $
��Wrap=�6,   $��20(�6@   
��� ���6N   �� 5J   
   $
 1133��6   $	 403��6#   $��40(�64   $��Instrucciones��6B   
��� ���6Z   5N      5O      