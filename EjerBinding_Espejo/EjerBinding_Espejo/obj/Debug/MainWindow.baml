   M S B A M L   `   `   `  ����M  IEjerBinding_Espejo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:EjerBinding_EspejoEjerBinding_Espejo  5   	   #    EjerBinding_Espejo.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:EjerBinding_Espejo     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   	� -   5         	�Name$ Opcion_1��5
      $��Opcion1��6)   $
��Left=�6;   $��	54,89,0,0q�6V   $	��Top=�6i   	� 5   
   -   5        $ Opcion2��5      $��Opcion2��6'   $
��Left=�69   $��
54,129,0,0q�6T   $	��Top=�6h   	� 5   
   -   5        $ Opcion3��5      $��Opcion 3��6'   $
��Left=�6:   $��
54,163,0,0q�6U   $	��Top=�6i   �� 5   
   -   5         ��Name$ Opcion4��5      $��Opcion 4��6$   $
��Left=�67   $��
264,92,0,0q�6R   $	��Top=�6f   �� 5   
   -   5        $ Opcion5��5      $��Opcion 5��6$   $
��Left=�67   $��264,129,0,0q�6R   $	��Top=�6g   �� 5   
   -   5        $ Opcion6��5      $��Opcion 6��6$   $
��Left=�67   $��264,166,0,0q�6R   $	��Top=�6g   $��21��6   �� 5   
   -   5         ��Name$ TextBox1��5      $
��Left=�6$   $��23��6?   $��
497,56,0,0q�6K    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��120��6�   �� 5   
   $��Espejo��6   $
��Left=�6!   $��
24,230,0,0q�6<   $	��Top=�6P   	� 5   
   -   5        $ Opcion_1_Copy��5       	� 	GroupName$ 1��6-   $��Opcion1��6;   $
��Left=�6M   $��
54,261,0,0q�6h   $	��Top=�6|   {�.   d� 	IsChecked 5      ��  �� ElementName$ Opcion_1�� �� Path$ 	IsChecked�	 �� Mode$	 OneWay=�	� 5   
   -	   5        $ Opcion2_Copy��5      $ 1��6-   $��Opcion2��6;   $
��Left=�6M   $��
54,306,0,0q�6h   $	��Top=�6|   {�.   5      �� $ Opcion2��$ 	IsChecked�$	 OneWay=�	� 5   
   -
   5        $ Opcion3_Copy��5      $ 1��6,   $��Opcion 3��6:   $
��Left=�6M   $��
54,355,0,0q�6h   $	��Top=�6|   {�.   5      �� $ Opcion3��$ 	IsChecked�$	 OneWay=��� 5   
   -   5        $ opcion4_Copy��5      $��Opcion 4��6)   $
��Left=�6<   $��264,261,0,0q�6W   $	��Top=�6l   {�.   5      �� $ Opcion4��$ 	IsChecked�$	 OneWay=��� 5   
   -   5        $ Opcion5_Copy��5      $��Opcion 5��6)   $
��Left=�6<   $��264,306,0,0q�6W   $	��Top=�6l   {�.   5      �� $ Opcion5��$ 	IsChecked�$	 OneWay=��� 5   
   -   5        $ Opcion6_Copy��5      $��Opcion 6��6)   $
��Left=�6<   $��264,358,0,0q�6W   $	��Top=�6l   $��21��6�   {�.   5      �� $ Opcion6��$ 	IsChecked�$	 OneWay=��� 5   
   -   5        $ 	caja_Copy��5      $
��Left=�6%   $��23��6@   $��497,261,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��120��6�   {�.  ��5      �� $ TextBox1��$
 Text�$	 OneWay=��� 5    
   -   5        
 ��Name$
 slider��5       $
��Left=�6!   $��520,170,0,0q�6<   $	��Top=�6Q   $��17��6i   $��70��6u   �� 5!   
   -   5        $
 slider_Copy��5!      $
��Left=�6&   $��520,362,0,0q�6A   $	��Top=�6V   $��17��6n   $��70��6z   {�.   � Value 5"      �� $ slider��$ Value�$	 OneWay=��� 5#   
   -   5         ��Name$ items��5#      $
��Left=�6"   $��497,110,0,0q�6=   $	��Top=�6R   $	��120��6j   .@�5$      �� $��item1��6   �� 5%      $��item2��6   �� 5&      $��item3��6   5'      �� 5(   
   -   5        $ 	item_copy��5(      $
��Left=�6&   $��497,306,0,0q�6A   $	��Top=�6V   $	��120��6n   {�.   �� SelectedIndex 5)      �� $ items��$ SelectedIndex�$	 OneWay=�.@�5*      �� $��item1��6   �� 5+      $��item2��6   �� 5,      $��item 3��6   5-      �� 5.   
   $��Label��6   $
��Left=�6    $��	54,38,0,0q�6;   $	��Top=�6N   5/      50      