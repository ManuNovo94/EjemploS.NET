   M S B A M L   `   `   `  ����R  NTransformaciones_objeto, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Transformaciones_objetoTransformaciones_objeto  5   	   (    "Transformaciones_objeto.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:Transformaciones_objeto     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ 
rectangulo��5
      ���	#FFFFC500$
��Left=�69   $��56,37,0,306q�6T   
���   �$	��134��6x   z�5      V� 5      .~�5      ��  �� Angle 6&   ��  �� Path$ Value� �� ElementName$ slider_rotacion���� 5       �� ScaleX 6$   �� $ Value�$ slider_escala�� �� ScaleY 6]   �� $ Value�$ slider_escala��T� 5       T� X 6)   �� $ Value�$ slider_desplazamiento�� T� Y 6f   �� $ Value�$ slider_desplazamiento��5      5      �� 5   
   -   5        	 ��Name$	 slider_desplazamiento��5      $
��Left=�60   $��538,336,0,0q�6K   $	��Top=�6`   $��21��6x   $	��203��6�   
 � Maximum$	
 300Q�6�   �� 5   
   $��Desplazamiento��6   $
��Left=�6)   $��592,305,0,0q�6D   $	��Top=�6Y    J� RenderTransformOrigin$ 0.263,-0.25&�6q   �� 5   
   -   5        $	 slider_rotacion��5      $
��Left=�6*   $��274,336,0,0q�6E   $	��Top=�6Z   $��60��6r   $	��220��6~   $	
 360Q�6�   �� 5   
   $��Rotacion��6   $
��Left=�6#   $��359,305,0,0q�6>   $	��Top=�6S   �� 5   
   -   5        $	 slider_escala��5      $
��Left=�6(   $��
27,336,0,0q�6C   $	��Top=�6W   $��21��6o   $	��215��6{    � Minimum$ 1Q�6�    �� IsDirectionReversed . 6�   �� 5   
   $��Escala��6   $
��Left=�6!   $��100,305,0,0q�6<   $	��Top=�6Q   5      5      