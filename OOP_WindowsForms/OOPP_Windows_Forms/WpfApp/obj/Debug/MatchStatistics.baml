   M S B A M L   `   `   `  ����A  =WpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WpfAppWpfApp  5   	       WpfApp.MatchStatistics   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:WpfApp     5   	   -   5        $��ms��5   	     � Title$  MatchStatistics��5   	   $	��450��6!   $	��800��6.   ���#646464 � 
ResizeMode$ NoResize=�5
   	    � Triggers 5      :� 5   
    :� RoutedEvent$ Window.Loaded��6   [�5      �� 5      .��5      ��  g� 	BeginTime$ 0X�6!    g� Duration$ 0:0:0.5D�6/   .��5      W�  �� 
TargetName$ ms��6*    �� TargetProperty$ (Window.Top)�6E    W� From$ 0X�6n   		 W� To$		 300X�6w   
 g� AutoReverse
 .  g� RepeatBehavior$ Forever��6�   W� 5      $ ms��6*   $ (Window.Left)�6E   $ 0X�6o   $		 400X�6x   
 . $ Forever��6�   5      5      5      .��5      � -   5        $��gStats��5       � ColumnDefinitions 5   
   �� 5      �� 5      $
��auto �6   �� 5      .+�5   
   �� $��Stretch=�6   
�������$��4��5!      $��1��5"      5#      5$      