   M S B A M L   `   `   `  ����  	Pizzaria1#    Pizzaria1.RequestDeletePrompt   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -   5          � Title$  W_MessageBox��5   	   $	��180��6   $	��400��6+   $	��500��67    � AllowsTransparency .  � WindowStyle$
 None=�6a    � WindowStartupLocation$ CenterScreen=�6�   ��6t   Z�  � Triggers 5	      :� 5
   
    :� RoutedEvent$ FrameworkElement.Loaded��6   .[�5      �� .��5      ��  g� FillBehavior$ HoldEnd=�6    g� AutoReverse .  .��5      W�  �� TargetProperty$ Opacity�6&   	 W� From$	 0X�6J   	
 W� To$
 1X�6S    g� Duration$ 0:0:0.3D�6Z   5      5      5      .��5      � .+�5   
   � -   5         �Name$ gBody��5       � RowDefinitions 5      �� 5      $��* �6    �� 5      $
��Auto �6    .+�5      �� $��1q�6   ���	#E5FFFFFF �� CornerRadius$ 20��6@   $��2��6R   ���	#FF7070706c   �� 5      -   5         ��Name$ txbText��5   -   $��Are you sure?��6   $��10,50,0,0.2q�6?   $��28(�6T   ���	#CC000000$��Center=�6z   ��. ��6�   Z� ��6�   Z� 6�   �� 5      $��Delete��6   $��Center=�6%   $	��Top=�6B   $��5q�6Z   
�������$��18(�6w   �� 5      -   5         ��Name$ btnYes��5      $	��YES��6:   $y�Visible=�6H      MyButton#��[  6]   ���	#CC000000
�������$��60,10,240,5q�6�   $��1��6�   
 J� Uid$ 1��6�   �� 5      -   5        $ btnNo��5      $��NO��6%   $y�Visible=�62   #��[  6G   ���	#CC000000
�������$��Right=�6�   $	��100��6�   $��	0,10,60,5q�6�   $��1��6�   $ 0��6�   5      � 5   
   -   5        $
 gBar��5       � Cursor$
 Hand��6   $��40��6+   $	��Top=�67   .+�5       �� ���	#19000000$ 	20,20,0,0��6,   �� 5!      -   5        $ btnClose��5!      $��X��6'     MyCloseButton#��[ 63   ���	#FFE74646
�������$��Right=�6�   $��58��6�   5#      5$      5%      