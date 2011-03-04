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

class MvpGenerator < GeneratorBase
  def generate
    @name = prompt 'Enter mvap name'

    file :in => "IModel.cs", :out => "I#{@name}Model.cs", 
      :sub_type => 'Code', :build_action => 'Compile'
      
    file :in => "IView.cs", :out => "I#{@name}View.cs", 
      :sub_type => 'Code', :build_action => 'Compile'
      
    file :in => "IAdapter.cs", :out => "I#{@name}Adapter.cs", 
      :sub_type => 'Code', :build_action => 'Compile'
      
    file :in => "Model.cs", :out => "#{@name}Model.cs", 
      :sub_type => 'Code', :build_action => 'Compile'
      
    file :in => "Adapter.cs", :out => "#{@name}Adapter.cs", 
      :sub_type => 'Code', :build_action => 'Compile'

file :in => "PresenterWithAdapter.cs", :out => "#{@name}Presenter.cs", 
      :sub_type => 'Code', :build_action => 'Compile'
      
    file :in => "TestModel.cs", :out => "Tests/Test#{@name}Model.cs", 
      :sub_type => 'Code', :build_action => 'Compile'
      
    file :in => "TestPresenterWithAdapter.cs", :out => "Tests/Test#{@name}Presenter.cs", 
      :sub_type => 'Code', :build_action => 'Compile'
  
    file :in => "TestAdapter.cs", :out => "Tests/Test#{@name}Adapter.cs", 
    :sub_type => 'Code', :build_action => 'Compile'
end

  def desc
    <<-EOS
    Generates files for an mvap quadlet.  These include
    a model, adapter, presenter, and tests for each, as well
    as interfaces for the model and view and adapter:

      Foo => FooPresenter.cs, FooModel.cs, TestFooPresenter.cs,
             TestFooModel.cs, IFooView.cs, IFooModel.cs
             IFooAdapter.cs, FooAdapter.cs, TestFooAdapter.cs

    EOS
  end
end

