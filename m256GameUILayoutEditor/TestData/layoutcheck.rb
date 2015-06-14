#!ruby -Ks
# -*- mode: ruby; Encoding: sjis; coding: sjis -*-
# Last updated: <2015/06/15 01:15:21 +0900>
#
# Ruby + DXRuby を使ってレイアウトを再現してみるテスト

require 'dxruby'
require 'yaml'

o = YAML.load_file("layout1.yml")

Window.resize(o[:canvas_w], o[:canvas_h])
sprs = []
o[:objs].each do |d|
  if d[:type] == 0
    img = Image.load(d[:path])
    spr = Sprite.new(d[:x], d[:y], img)
    sprs.push(spr)
  else
    fnt = Font.new(d[:fontsize], d[:fontname])
    img = Image.new(640, 480)
    img.drawFont(0, 0, d[:text], fnt, d[:fontcolor])
    spr = Sprite.new(d[:x], d[:y], img)
    sprs.push(spr)
  end
end

Window.loop do
  break if Input.keyPush?(K_ESCAPE)
  Sprite.draw(sprs)
end


