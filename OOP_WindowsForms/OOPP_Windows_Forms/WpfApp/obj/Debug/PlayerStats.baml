   M S B A M L   `   `   `  ����A  =WpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WpfAppWpfApp  5   	       WpfApp.PlayerStats   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:WpfApp     5   	   -   5        $��ps��5
   	     � Title$  PlayerStats��5   	   $	��450��6   $	��800��6*   ���#646464 � Triggers 5      :� 5   
    :� RoutedEvent$ Window.Loaded��6   [�5      �� 5      .��5      ��  g� 	BeginTime$ 0X�6!    g� Duration$ 0:0:0.3D�6/   .��5      W�  �� TargetProperty$ Width�6*    �� 
TargetName$ ps��6L    W� From$	 800X�6g   	 W� To$
 1000X�6r   W� 5      $ Height�6*   $ ps��6M   $	 450X�6h   $	 650X�6s   5      5      5      	 � 	Resources	 5      
 �� 
TargetType �� Property �� Value��%�   '��       �� 5   
   "
 ��6   .�5      ��  � ��$ 24(�6)   �� 5       � ��$
 Bold"�6+   �� 5       � ��
 � ���6+   �� 5       � ��$ Center=�64   �� 5       � ��$ Center=�62   5      5      .��5       �  � ColumnDefinitions 5!   
   �� 5"      �� 5#       � RowDefinitions 5%   
   �� 5&      �� 5'      �� 5(      �� 5)      �� 5*      �� 5+      .+�5.   
   �� -   5        $��pImage��5.      $��0��5/      $��0��50      $��6��51      52      �� 53   
   -   5        $��pName��53      $��1��54      $��0��55      56      �� 57   
   -   5        $��pNumber��57      $��1��58      $��1��59      5:      �� 5;   
   -   5        $��	pPosition��5;      $��1��5<      $��2��5=      5>      �� 5?   
   -   5        $��pRole��5?      $��1��5@      $��3��5A      5B      �� 5C   
   -   5        $��pGoalsScored��5C      $��1��5D      $��4��5E      5F      �� 5G   
   -   5        $��pYellowCards��5G      $��1��5H      $��5��5I      5J      5K      5L      