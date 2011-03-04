#!/usr/bin/ruby

# Copyright (C) 2005-2011 by Atomic Object, LLC (http://atomicobject.com)
# 
# Permission is hereby granted, free of charge, to any person obtaining a copy
# of this software and associated documentation files (the "Software"), to deal
# in the Software without restriction, including without limitation the rights
# to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
# copies of the Software, and to permit persons to whom the Software is
# furnished to do so, subject to the following conditions:
# 
# The above copyright notice and this permission notice shall be included in
# all copies or substantial portions of the Software.
# 
# THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
# IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
# FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
# AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
# LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
# OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
# THE SOFTWARE.

require 'code_generator/generator'

class InterfaceGenerator < GeneratorBase
  def generate
    @name = prompt 'Enter interface name'
    @iface_name = 'I' + @name.gsub(/^I/,'')
    @class_name = @name.gsub(/^I/,'')

    @with_impl = prompt 'Generate Implmentation [Y/n]'
    @with_impl = !(@with_impl =~ /\s*n/i)
    
    file :in => "Interface.cs", :out => "#{@iface_name}.cs", 
      :sub_type => 'Code', :build_action => 'Compile'

    if @with_impl 
      file :in => "Class.cs", :out => "#{@class_name}.cs", 
        :sub_type => 'Code', :build_action => 'Compile'

      file :in => "Test.cs", :out => "Tests/Test#{@class_name}.cs", 
        :sub_type => 'Code', :build_action => 'Compile'
    end
  end

  def desc
    <<-EOS
    Generates an interface (with option implementation):

      IFoo => IFoo.cs, (Foo.cs, TestFoo.cs)
      Foo => IFoo.cs, (Foo.cs, TestFoo.cs)

    EOS
  end
end

