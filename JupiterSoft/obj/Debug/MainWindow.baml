   M S B A M L   `   `   `  ����F  BJupiterSoft, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:JupiterSoftJupiterSoft  5   	       JupiterSoft.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  6F   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   L HModernWpf.MahApps, Version=0.9.4.0, Culture=neutral, PublicKeyToken=nullD @ModernWpf, Version=0.9.4.0, Culture=neutral, PublicKeyToken=nullM IModernWpf.Controls, Version=0.9.4.0, Culture=neutral, PublicKeyToken=null.ui!http://schemas.modernwpf.com/2019    5   	   )localclr-namespace:JupiterSoft    5   	   0  *ModernWpf.Controls.Primitives.WindowHelper    UseModernWindowStyle  .  � Title$ JUPITER SOFTWARE��5
   	    � Icon$ icon.ico��5   	   $	��650��5   	   $
��1000��6   !  ModernWpf.Controls.TitleBar   
Background �#e4e4e4   IsIconVisible .  � WindowState$ 	Maximized=�5   	    � 
ResizeMode$ CanMinimize=�5   	   .��5      �  � RowDefinitions 5   
   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   ��5   
   �� 5      	 �� ImageSource$	 /assets/welcome.jpg��6   .+�5   
   � $��0��6    5       �� 5!      $��* �6    �� 5"      $��* �6     5$      �� 5%      $��* �6#   .+�5(      �� $��0��6   
 �� Orientation$
 
Horizontal=�6)   $��	0,317,0,0q�6B   $��Center=�6U   $��2��6r   $	��500��6�   .+�5)      �� -   5         ��Name$ StartNew��5)      ���#FFF
������ $��START CREATING��6V    � Cursor$
 Hand��6o   $��Center=�6}   $��Center=�6�   $��0,12,0,0q�6�      StartButton#��[  6�    � ToolTip$! Start Creating New Template��6�   6  �� 5,      -   5        $ 
StartSaved��5,      ���#0082ca
������ $��RUN THE SAVED PROJECTS��6^   $
 Hand��6   $��Center=�6�   $��Center=�6�   $��	15,12,0,0q�6�     SavedButton#��[ 6�   $ Run Saved Template��6�   6  5-      5.      50      51      