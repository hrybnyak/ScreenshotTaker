   M S B A M L   `   `   `  ����M  IScreenshotTaker.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:ScreenshotTaker.UIScreenshotTaker.UI  5   	   $    ScreenshotTaker.UI.ColorPicker   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:ScreenshotTaker.UI     5   	     � Title$  ColorPicker��5   	   $	��251��6   $	��219��6*   
������� � WindowStyle$ 
ToolWindow=�6I   .��5	      � $��0,0,2,0q�6   .+�5
   
   �� -   5         ��Name$ redColorSlider��5
       � Minimum$ 0Q�6)    � Maximum$	 255Q�65   $��9,12,0,0q�6C   $��19��6v   $	��Top=�6�   $
��Left=�6�   $	��179��6�   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ Black��6#    � Offset$ 0Q�61   � 5      $	 Red��6#   $ 1Q�6/   � 5      $ White��6#   $
 0.02Q�61   5      5      �� 5   
   -   5        $ greenColorSlider��5      $ 0Q�6+   $	 255Q�67   $��9,43,0,0q�6E   $��19��6x   $	��Top=�6�   $
��Left=�6�   $	��179��6�   ��5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   .��5      � $ White��6#   $ 0Q�61   � 5      $ 	#FF00CF13��6#   $ 1Q�65   5      5      �� 5   
   -   5        $ blueColorSlider��5      $ 0Q�6*   $	 255Q�66   $��9,75,0,0q�6D   $��19��6w   $	��Top=�6�   $
��Left=�6�   $	��179��6�   ��5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   .��5      � $ White��6#   $ 0Q�61   � 5      $ 	#FF000CFF��6#   $ 1Q�65   5       5"      �� 5$   
   -   5        	 ��Name$	 label��5$      $�� ��6   $��160,111,0,0q�6*   $��27��6?   $	��Top=�6K   $
��Left=�6c   $��28��6~   �� 5%   
   -   5        $	 	labelInfo��5%      $��Color selected��6#   $��
68,111,0,0q�6<   $��27��6P   $	��Top=�6\   $
��Left=�6t   $��87��6�   �� 5&   
   -   5        $ thicknessSlider��5&      $
��Left=�6*   $��	9,186,0,0q�6E   $	��Top=�6X   $	��179��6p   $ 1Q�6|   $ 15Q�6�   $��19��6�   #��� ��6�   �� 5'   
   -   5        $	 secondLabelInfo��5'      $��Tickness��6)   $��	9,154,0,0q�6<   $��27��6O   $	��Top=�6[   $
��Left=�6s   $	��123��6�   5)      5*      