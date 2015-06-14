#!ruby -Ks
# -*- mode: ruby; Encoding: sjis; coding: sjis -*-
# Last updated: <2015/06/15 01:06:46 +0900>
#
# YAML形式の確認

require 'yaml'
require 'pp'

a = {
  :canvas_w => 640,
  :canvas_h => 480,
  :objs => [
  {
    :fontname => "Arial",
    :fontcolor => [0,0,255],
  },
  {
    :fontname => "",
    :fontcolor => [0,0,255],
  },
  ],
}

pp a
puts a.to_yaml()

