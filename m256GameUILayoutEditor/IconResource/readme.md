## ImageMagick を使って画像を分割

    convert -crop 16x16 +repage +adjoin -page +0+0 m256gule_toobar_base.png icon_%02d.png

- -crop は、16x16ドットずつ分割するという指定
- +repage は、出力画像の仮想キャンバスを無くす指定
- +adjoin はよく分からず。
- -page +0+0 はオフセット値を0,0にせよという指定

ImageMagick 6.9.1-2 Q16 x86 では +repage が働いてないのかもしれない。出力画像をGIMPで開いたら「オフセット値があるけどレイヤーに反映させるか？」と尋ねてきた。そのあたりの情報を削除するはずの指定なのに…。-page +0+0 をつけたら尋ねてこなくなった。

