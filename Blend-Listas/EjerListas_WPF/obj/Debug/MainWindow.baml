   M S B A M L   `   `   `  ����I  EEjerListas_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:EjerListas_WPFEjerListas_WPF  5   	       EjerListas_WPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:EjerListas_WPF     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	       
  Linea1 �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value8  2System.Windows.Media.Animation.EasingPointKeyFrame $� KeyTime $� Value R� KeyTime  System.Windows.Visibility	   Visible
 R� Value   Hidden��%�  &	        �� 5
   
   .��5      U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6,   $ 	rectangle��6�   .\�5        $ 0��6'   $ 0Q�63     5      $ 0:0:1��6'   $ 0.635Q�67     5      $ 0:0:2��6'   $
 4.86Q�67     5      $ 0:0:2.9��6'   $ -48.37Q�69   5      U� 5      $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�6,   $ 	rectangle��6�   .\�5        $ 0��6'   $ -1Q�63     5      $ 0:0:1��6'   $ -0.696Q�67     5      $ 0:0:2��6'   $ -5.725Q�67     5      $ 0:0:2.9��6'   $ 3.534Q�69   5      U� 5      $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)�6,   $ 	rectangle��6�   .\�5        $ 0��6'   $ 0.989Q�63     5      $ 0:0:1��6'   $ 0.986Q�67     5      $ 0:0:2��6'   $
 0.99Q�67     5      $ 0:0:2.9��6'   $ 1.008Q�69   5      U� 5      $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�6,   $ 	rectangle��6�   .\�5        $ 0��6'   $ 0.994Q�63     5      $ 0:0:1��6'   $ 1Q�67     5       $ 0:0:2��6'   $ 1.001Q�67     5!      $ 0:0:2.9��6'   $ 1.013Q�69   5"      *� 5#      $' !(UIElement.RenderTransformOrigin)�6+   $ 	rectangle��6i   .'�5$        $ 0��6&   $ 0.5,0.5&�62     5%      $ 0:0:2.9��6&   $ -3.965,1.423&�68   5&      U� 5'      $ (UIElement.Opacity)�6,   $ 	rectangle��6\   .\�5(        $ 0��6'   $ 1Q�63     5)      $ 0:0:1��6'   $	 0.5Q�67     5*      $ 0:0:2��6'   $
 0.12Q�67     5+      $ 0:0:2.9��6'   $ 0Q�69   5,      T� 5-      $ (UIElement.Visibility)�6,   $ 	rectangle��6_   ..�5.      i� $ 0:0:2��6)   #
 Z	 69   i� 5/      $ 0:0:2.9��6)   #
 Z 6;   50      51      52       � Triggers 53      :� 54   
    :� RoutedEvent$ FrameworkElement.Loaded��6   .[�55      �� #��[  6   56      .��58      � -   5         �Name$ 	Apellidos��58      .+�59   
   �� $��Nombre��6   $
��Left=�6!   $��	89,26,0,0q�6<   $	��Top=�6O   �� 5:   
   $��	Apellidos��6   $
��Left=�6$   $��	89,89,0,0q�6?   $	��Top=�6R   $��35��6j   $��59��6v   �� 5;   
   -   5         ��Name$ Nombre��5;      $
��Left=�6"   $��28��6=   $��
212,26,0,0q�6I    �� TextWrapping$
 Wrap=�6]   $	��Top=�6q   $	��260��6�   �� 5<   
   -   5        $ Apellido��5<      $
��Left=�6$   $��29��6?   $��
212,95,0,0q�6K   $
 Wrap=�6_   $	��Top=�6s   $	��260��6�   6�   �� 5=   
   -   5         ��Name$ Boton��5=      $��Añadir elemento��6    $
��Left=�6:   $��288,160,0,0q�6U   $	��Top=�6j   $	��184��6�   $��32��6�   6�   �� 5>   
   -   5         ��Name$ Lista��5>      $
��Left=�6!   $��48��6<   $��268,221,0,0q�6H   $	��Top=�6]   $	��300��6u   � 5?   
   -   5         �Name$ barra��5?      $
��Left=�6%   $��24��6@   $��241,314,0,0q�6L   $	��Top=�6a   $	��342��6y   �� 5@   
   -   5         ��Name$ label��5@      $�� ��6   $
��Left=�6*   $��326,365,0,0q�6E   $	��Top=�6Z   $	��177��6r   �� 5A   
   -   5         ��Name$ 	rectangle��5A      $
��Left=�6'   $��417.044��6B   
���   �$	��Top=�6b   $	��792��6z    J� RenderTransformOrigin$ 0.5,0.5&�6�   ��5B      �� 5C       �� ImageSource$ 
atenas.PNG��6   z�5E      V� 5F      .~�5G      �� �� 5H      �� 5I      T� 5J      5K      5M      5O      5P      