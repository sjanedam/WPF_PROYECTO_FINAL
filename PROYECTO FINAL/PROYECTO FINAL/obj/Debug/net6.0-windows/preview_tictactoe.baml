   M S B A M L   `   `   `  ����I  EPROYECTO FINAL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:PROYECTO_FINALPROYECTO_FINAL  5   	   &     PROYECTO_FINAL.preview_tictactoe   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:PROYECTO_FINAL     5   	     � Title$  	ENTRE10TE��5   	   $	��900��6   $
��1600��6(   $��Multicolore)�5	   	    � WindowState$ 	Maximized=�5
   	    � 	Resources 5       �� 
TargetType 
  estilo �� Property �� Value �� 
TargetType �� CornerRadius ��Name	 �� Triggers
 P� Property P� Value 
 goBack J� Opacity��%  &	        &	 >    �� 5   
   " ��6   .�5      ��  �@�OverridesDefaultStyle$
 True��66   �� 5       �@�Cursor$
 Hand��6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      � #��z��6   .+�5      �� $ 25��6%   ���	#FFFF8A2367   �� 5      $ MyContentPresenter��6/   #��z��6K   $��Center=�5   +   $��Center=�6H   ���	#FFFFFCE9$��30(�5   L   5      5      5      5      	 5       P� 5!      
 �@J�IsMouseOver$
 True��61   . �5"      ��  � �� 5#      �� 5$      " ��6.   .R�5%   "   � #��z��6'   .+�5&   &   �� $ 25��6-   ���#FACC8D6?   �� 5'   &   $ MyContentPresenter��67   #��z��6S   $��Center=�5(   +   $��Center=�6H   ���	#FFFFFCE9$��29(�5)   L   5*   '   5+   #   5,      5.      5/      51      �� 54   
   " ��6   .�55      ��  �@�OverridesDefaultStyle$
 True��66   �� 56       �@�Cursor$
 Hand��6'   �� 58       � �� 59      �� 5:      " ��6&   .R�5;      � #��z��6   .+�5<      �� $ 15��6%   ���	#FFFF8A23$	 0.5Q�6N   �� 5=      $ MyContentPresenter��6/   #��z��6K   $��Center=�5>   +   $��Center=�6H   ���	#FFFFFCE9$��20(�5?   L   5@      5A      5B      5D      5E      5F      .��5G      � ���	#FFFFFCE9.+�5I   
   �� -   5        $
��Left=�5I      $��1480,28,0,0q�6,   $	��Top=�6A   $��40��6Y   $��40��6e   #��[ 6p   .��5K      ��  �� Orientation$ 
Horizontal=�6   .+�5L      �� $
��Left=�6   $��35��63   $	��Top=�6?   $��35��6W   $��/goback.png��6b   5M      5N      �� 5Q   
   -   5         ��Name$ myMediaElement��5Q   %   $��128,0,914,0q�6   $��/tresenraya.png��6=   5R      � 5V   
   $��800,60,30,30q�6   .+�5X      �� $
��Left=�6   $	��100��6/   $��332,-15,0,0q�6<   $	��Top=�6Q   $	��100��6i   $��	/logo.png��6u   �� 5Z      -   5         ��Name$ Nombre��5[   7   $��Nombre��5Z      $
��Left=�6%   $��	80,96,0,0q�6@   $	��Top=�6S   $��Multicolore)�5[      $��80(�6)   ���	#FFFF8A236G   �� 5\      $
��Left=�6   $��7��63   $��
80,203,0,0q�6>   ���	#FFFF8A23$	��Top=�6c   $	��200��6{   �� 5]      -   5         ��Name$ Descripcion��5^   T   $��Center=�5]      $
��Wrap=�65   $	��Top=�6I   $��Multicolore)�5^      $��25(�6-   $	��221��6;   $	��610��6H   $��	0,240,0,0q�6i   �� 5_      $�	TextBlock��6    �� 5`       � Language$ es-es�6   $��z textblock textblock textblock textbvksiokvhsd sakvjdiavkjvk sjaskfka shjaskhfjah safhjhasjkfha jashjskhfaj jsfhasjhfjakha��6'   5a      �� 5d      $
��Left=�6   $��48��6/   $��100,465,0,0q�6;   $	��Top=�6P   $��48��6h   $��/favorito.png��6s    J� RenderTransformOrigin$ 0.5,0.5&�6�   �� 5e      $��
Dificultad��6   $
��Left=�6)   $��150,472,0,0q�6D   $	��Top=�6Y   $��Multicolore)�5f      $��20(�6-   �� 5g      -   5        $ 
Dificultad��5h   8   $��
Dificultad��5g      $
��Left=�6)   $��150,497,0,0q�6D   $	��Top=�6Y   $��Multicolore)�5h      $��15(�6*   ���	#FFFF8A236M   �� 5l      $
��Left=�6   $��48��6/   $��100,562,0,0q�6;   $	��Top=�6P   $��48��6h   $��/favorito.png��6s   $ 0.5,0.5&�6�   �� 5n      $
��Tipo��6   $
��Left=�6#   $��150,570,0,0q�6>   $	��Top=�6S   $��Multicolore)�5o      $��20(�6*   �� 5p      -   5        $
 Tipo��5q   <   $
��Tipo��5p      $
��Left=�6#   $��150,596,0,0q�6>   $	��Top=�6S   $��Multicolore)�5q      $��15(�6.   ���	#FFFF8A236J   �� 5u      -   5        $��Center=�5u      $	��Top=�62   $��50��6J   $	��600��6V   $��	0,650,0,0q�5v      $��Jugar ahora��6@   #��[  6V   5w      5y      5�      5�      